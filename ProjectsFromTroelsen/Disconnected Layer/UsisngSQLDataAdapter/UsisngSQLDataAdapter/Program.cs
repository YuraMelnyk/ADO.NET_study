using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;


namespace UsisngSQLDataAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Work with Data Adapter*********");

            string connectionString = "Integrated Security = SSPI; Initial Catalog = AutoLot;" + @"Data Source = (local)\SQLEXPRESS";
            DataSet ds = new DataSet("AutoLot");

            SqlDataAdapter adapter = new SqlDataAdapter("Select * From Inventory", connectionString);
            adapter.Fill(ds, "Inventory");
            PrintDataSet(ds);
            Console.ReadLine();
        }

        static void PrintDataSet(DataSet ds)
        {
            Console.WriteLine($"DataSet is name: {ds.DataSetName}");
            foreach (DictionaryEntry de in ds.ExtendedProperties)
            {
                Console.WriteLine($"Key ={de.Key}, Value = {de.Value}");
            }
            Console.WriteLine();

            //Show Contend 
            foreach (DataTable dt in ds.Tables)
            {
                Console.WriteLine($"=> {dt.TableName} Table:");
                for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
                {
                    Console.Write($"{dt.Columns[curCol].ColumnName} \t");
                }
                Console.WriteLine("\n------------------------------------");
                for (int curRow = 0; curRow < dt.Rows.Count; curRow++)
                {
                    for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
                    {
                        Console.Write($"{dt.Rows[curRow][curCol]} \t");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
