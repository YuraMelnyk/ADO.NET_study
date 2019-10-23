using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using static System.Console;

namespace Troelsen_AutoLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataProvider = ConfigurationManager.AppSettings["provider"];
            string connectionString = ConfigurationManager.AppSettings["connectionString"];

            DbProviderFactory factory = DbProviderFactories.GetFactory(dataProvider);

            using (DbConnection connection = factory.CreateConnection())
            {
                if (connection == null)
                {
                    WriteLine("Connection");
                    return;
                }
                WriteLine($"Yuor connection object is a: {connection.GetType().Name}");
                connection.ConnectionString = connectionString;
                connection.Open();

                DbCommand command = factory.CreateCommand();
                if (command == null)
                {
                    WriteLine("Command");
                    return;
                }
                WriteLine($"Yuor command object is a: {connection.GetType().Name}");
                command.Connection = connection;
                command.CommandText = "Select * From Inventory";

                using(DbDataReader dataReader= command.ExecuteReader())
                {
                    WriteLine($"Your data reader object is a: {dataReader.GetType().Name}");
                    WriteLine("\n*****CurrentInventory*****");
                    while (dataReader.Read())
                        WriteLine($"-> Car #{dataReader["CarId"]} is a {dataReader["Make"]}.");
                }
            }

            ReadLine();
        }


    }
}
