using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AutoLotDAL.Models;

namespace AutoLotDAL.ConnectedLayer
{
    public class InventoryDAL
    {
        private SqlConnection _sqlConnection = null;
        public void OpenConnection(string connectionString)
        {
            _sqlConnection = new SqlConnection { ConnectionString = connectionString };
            _sqlConnection.Open();
        }
        public void CloseConnectin()
        {
            _sqlConnection.Close();
        }

        public void InsertAuto(int id, string color, string make, string petName)
        {
            string sql = "Insert Into Inventory" + $"(Make, Color, PetName) Values ('{make}', '{color}', '{petName}')";
            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.ExecuteNonQuery();
            }
        }

        public void InsertAuto(NewCar car)
        {
            string sql = "Insert Into Inventory" + $"(Make, Color, PetName) Values ('{car.Make}', '{car.Color}', '{car.PetName}')";
            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.ExecuteNonQuery();
            }
        }

        public void DeleteCar(int id)
        {
            string sql = $"Delete from Inventory where CarId = '{id}'";

            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Exception error = new Exception("Sorry! That car is on order!", ex);
                    throw error;
                }
            }
        }

        public void UpdateCar(int id, string newColor, string newPetName)
        {
            string sql = $"Update Inventory Set PetName = '{newPetName}' And Color = '{newColor}' Where CarId = '{id}'";
            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.ExecuteNonQuery();
            }
        }

        public List<NewCar> GetAllInventoryAsList()
        {
            List<NewCar> inv = new List<NewCar>();

            string sql = "Select * From Inventory";
            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    inv.Add(new NewCar
                    {
                        CarId = (int)dataReader["CarId"],
                        Color = (string)dataReader["Color"],
                        Make = (string)dataReader["Make"],
                        PetName = (string)dataReader["PetName"]
                    });
                }
                dataReader.Close();
            }
            return inv;
        }
        public DataTable GetAllInventoryAsDataTable()
        {
            DataTable dataTable = new DataTable();
            string sql = "Select * From Inventory";
            using (SqlCommand cmd = new SqlCommand(sql, _sqlConnection))
            {
                SqlDataReader dataReader = cmd.ExecuteReader();
                dataTable.Load(dataReader);
                dataReader.Close();
            }
            return dataTable;
        }

        public string LookUpPetName(int carId)
        {
            string carPetName;
            using (SqlCommand command = new SqlCommand("GetPetName", _sqlConnection))
            {
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter
                {
                    ParameterName = "@carId",
                    SqlDbType = SqlDbType.Int,
                    Value = carId,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(param);

                param = new SqlParameter
                {
                    ParameterName = "@petName",
                    SqlDbType = SqlDbType.Char,
                    Size = 10,
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(param);
                command.ExecuteNonQuery();
                carPetName = (string)command.Parameters["@petName"].Value;
            }
            return carPetName;
        }

        public void ProcessCreditRisk(bool throwEx, int custId)
        {
            string fName = string.Empty;
            string lName = string.Empty;
            SqlCommand cmdSelect = new SqlCommand(string.Format("Select * from Custumer where custId = {0}", custId), _sqlConnection);
            using (SqlDataReader dr = cmdSelect.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    dr.Read();
                    fName = (string)dr["FirstName"];
                    lName = (string)dr["LastName"];
                }
                else return;

                SqlCommand cmdRemove = new SqlCommand(string.Format("Delete from Custumer where custId = {0}", custId), _sqlConnection);
                SqlCommand cmdInsert = new SqlCommand(string.Format("Insert into CreditRisk" + "(CustId, FirstName, LastName)" + 
                    " '{0}','{1}','{2}'", custId, fName, lName), _sqlConnection);
                SqlTransaction tx = null;
                try
                {
                    tx = _sqlConnection.BeginTransaction();
                    cmdInsert.Transaction = tx;
                    cmdRemove.Transaction = tx;

                    if (throwEx)
                    {
                        throw new Exception("Sorry! Database error...Transaction feild.");
                    }
                    tx.Commit();
                }
                catch( Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    tx.Rollback();
                }
            }
        }
    }
}
