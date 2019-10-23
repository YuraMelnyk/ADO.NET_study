using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static System.Console;

namespace AytoLotDataReader
{
    class Program
    {
        static void Main(string[] args)
        {
            using(SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source = (local)\SQLEXPRESS; Integrated Security = SSPI;" +
                    "Initial Catalog = AutoLot";
                connection.Open();

                string sql = "Select * From Inventory";
                SqlCommand myCommand = new SqlCommand(sql, connection);

                using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                {
                    //while (myDataReader.Read())
                    //{
                    //    WriteLine($"-> Make {myDataReader["Make"]},\t PetName {myDataReader["PetName"]},\t Color {myDataReader["Color"]}");
                    //}

                    while (myDataReader.Read())
                    {
                        WriteLine("****Record****");
                        for (int i = 0; i < myDataReader.FieldCount; i++)
                        {
                            WriteLine($"{myDataReader.GetName(i)} = {myDataReader.GetValue(i)}");
                        }
                        WriteLine();
                    }
                }
            }
            ReadLine();
        }
    }
}
