using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotDAL.DataSets;
using AutoLotDAL.DataSets.AutoLotDataSetTableAdapters;

namespace AutoLotDataSetTableAdapters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Work with Strongly Typed DataSet***********");

            var table = new AutoLotDataSet.InventoryDataTable();
            var adapter = new InventoryTableAdapter();
            //AddRecords(table, adapter);
            
            adapter.Fill(table);
            RemoveRecords(table, adapter);
            adapter.Fill(table);
            PrintInventory(table);
            Console.ReadLine();
        }

        static void PrintInventory(AutoLotDataSet.InventoryDataTable table)
        {
            for (int curCol = 0; curCol < table.Columns.Count; curCol++)
            {
                Console.Write(table.Columns[curCol].ColumnName + " \t");
            }
            Console.WriteLine("\n-----------------------------------");
            for (int curRow = 0; curRow < table.Rows.Count; curRow++)
            {
                for (int curCol = 0; curCol < table.Columns.Count; curCol++)
                {
                    Console.Write(table.Rows[curRow][curCol] + " \t");
                }
                Console.WriteLine();
            }
        }

        public static void AddRecords(AutoLotDataSet.InventoryDataTable table, InventoryTableAdapter adapter)
        {
            try
            {
                //add new row
                AutoLotDataSet.InventoryRow newRow = table.NewInventoryRow();
                Console.WriteLine("Enter new color:");
                newRow.Color = (string)Console.ReadLine();
                Console.WriteLine("Enter new Make:");
                newRow.Make = (string)Console.ReadLine();
                Console.WriteLine("Enter new PetName:");
                newRow.PetName = (string)Console.ReadLine();
                table.AddInventoryRow(newRow);

                ////another way (Dont forget about position in constructor)
                //Console.WriteLine("Enter new color:");
                //string strColor = (string)Console.ReadLine();
                //Console.WriteLine("Enter new Make:");
                //string strMake = (string)Console.ReadLine();
                //Console.WriteLine("Enter new PetName:");
                //string strPetName = (string)Console.ReadLine();
                //table.AddInventoryRow(strMake, strColor, strPetName);

                adapter.Update(table);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void RemoveRecords(AutoLotDataSet.InventoryDataTable tb, InventoryTableAdapter adapter)
        {
            try
            {
                Console.WriteLine("Enter carId what you want delete: ");
                int carIdToDelete = int.Parse(Console.ReadLine().ToString());
                AutoLotDataSet.InventoryRow rowToDelete = tb.FindByCarId(carIdToDelete) ;
                adapter.Delete(rowToDelete.CarId, rowToDelete.Make, rowToDelete.Color, rowToDelete.PetName);
                adapter.Update(tb); 
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);             
            }
        }
    }
}
