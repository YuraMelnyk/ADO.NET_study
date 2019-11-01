using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AutoLotDAL.DataSets;
using AutoLotDAL.DataSets.AutoLotDataSetTableAdapters;

namespace LinqToDataSetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********LINQ over DataSet***********");
            AutoLotDataSet dal = new AutoLotDataSet();
            InventoryTableAdapter tableAdapter = new InventoryTableAdapter();
            AutoLotDataSet.InventoryDataTable data = tableAdapter.GetData();

            Console.ReadLine();
        }

        static void PrintAllCarIds(DataTable data)
        {
            EnumerableRowCollection enumData = data.AsEnumerable();

            foreach (DataRow r in enumData)
            {
                Console.WriteLine($"Car ID = {r["CarId"]}");
            }
        }


    }
}
