using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using static System.Guid;

namespace SimpleDataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Fun with DataSet***");
            var carsInventoryDS = new DataSet("Car Inventory" );
            carsInventoryDS.ExtendedProperties["TimeStamp"] = DateTime.Now;
            carsInventoryDS.ExtendedProperties["DataSetId"] = Guid.NewGuid();
            carsInventoryDS.ExtendedProperties["Company"] = "Mikko's Hot Tub Super Store";

            FillDataSet(carsInventoryDS);
            PrintDataSet(carsInventoryDS);
            ManipulateDataRowState();

            Console.ReadLine();

        }

        static void FillDataSet(DataSet ds)
        {
            //Create new Column
            var carIdColumn = new DataColumn("CarId", typeof(int))
            {
                Caption = "Car ID",
                ReadOnly = true,
                AllowDBNull = false,
                Unique = true,
                AutoIncrement = true, 
                AutoIncrementSeed = 1,
                AutoIncrementStep = 1
            };
            var carMakeColumn = new DataColumn("Make", typeof(string));
            var carColorColumn = new DataColumn("Color", typeof(string));
            var carPetNameColumn = new DataColumn("PetName", typeof(string))
            {
                Caption = "Pet Name"
            };

            //add to DataTable
            var inventoryTable = new DataTable("Inventory");
            inventoryTable.Columns.AddRange(new[]
            {
                carIdColumn, carMakeColumn, carColorColumn,carPetNameColumn
            });

            //create new Rows
            DataRow carRow = inventoryTable.NewRow();
            carRow["Make"] = "BMW";
            carRow["Color"] = "Black";
            carRow["PetName"] = "Hamlet";
            // or
            carRow[1] = "Saab";
            carRow[2] = "Red";
            carRow[3] = "Sea Breaze";
            inventoryTable.Rows.Add(carRow);

            //Create primary key
            inventoryTable.PrimaryKey = new[] { inventoryTable.Columns[0] };

            //Add DataTable in DataSet
            ds.Tables.Add(inventoryTable);
        }

        //Work with RowState
        private static void ManipulateDataRowState()
        {
            Console.WriteLine("-----------RowState-------------");

            var temp = new DataTable("Temp");
            temp.Columns.Add(new DataColumn("TempColumn", typeof(int)));

            var tempRow = temp.NewRow();
            Console.WriteLine($"After calling NewRow(): {tempRow.RowState}");

            temp.Rows.Add(tempRow);
            Console.WriteLine($"After calling Rows.Add(): {tempRow.RowState}");

            tempRow["TempColumn"] = 10;
            Console.WriteLine($"After first assignment: {tempRow.RowState}");

            temp.AcceptChanges();
            Console.WriteLine($"After calling AcceptChanges: {tempRow.RowState}");

            tempRow["TempColumn"] = 11;
            Console.WriteLine($"After first assignment: {tempRow.RowState}");

            temp.Rows[0].Delete();
            Console.WriteLine($"After calling Delete: {tempRow.RowState}");
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
