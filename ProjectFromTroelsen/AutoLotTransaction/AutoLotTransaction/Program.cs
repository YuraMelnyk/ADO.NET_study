using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotDAL.ConnectedLayer;
using AutoLotDAL.Models;
using System.Data;

namespace AutoLotTransaction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******Simple Transaction Example*******");
            bool throwEx = true;
            Console.Write("Do you want to throw an exeption (Y or N):");
            var answerUser = Console.ReadLine();
            if (answerUser?.ToLower() == "n")
            {
                throwEx = false;
            }
            var dal = new InventoryDAL();
            dal.OpenConnection(@"Data Source = (local)\SQLEXPRESS; Integrated Security = SSPI;" + "Initial Catalog = AutoLot");
            dal.ProcessCreditRisk(throwEx, 2);
            Console.WriteLine("Check CreditRisk table for results.");
            Console.ReadLine();
        }
    }
}
