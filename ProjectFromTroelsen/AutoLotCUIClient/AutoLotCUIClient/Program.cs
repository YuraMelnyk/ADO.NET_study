using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotDAL;
using System.Configuration;
using System.Data;
using AutoLotDAL.ConnectedLayer;
using AutoLotDAL.Models;
using static System.Console;

namespace AutoLotCUIClient
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("***** The AutoLot Console UI *****");
            string connectionString = ConfigurationManager.ConnectionStrings["AutoLotSqlProvider"].ConnectionString;
            bool userDone = false;
            string userCommand = "";

            InventoryDAL invDAL = new InventoryDAL();
            invDAL.OpenConnection(connectionString);
            try
            {
                ShowInstruction();
                do
                {
                    Write("\nPlease enter yuor command:");
                    userCommand = ReadLine();
                    WriteLine();
                    switch (userCommand?.ToUpper()??"")
                    {
                        case "I":
                            InsertNewCar(invDAL);
                            break;
                        case "U":
                            UpdateCarPetName(invDAL);
                            break;
                        case "D":
                            DeleteCar(invDAL);
                            break;
                        case "L":
                            ListInventory(invDAL);
                            break;
                        case "S":
                            ShowInstructions();
                            break;
                        case "P":
                            LookUpPetName(invDAL);
                            break;
                        case "Q":
                            userDone = true;
                            break;
                        default:
                            WriteLine("Bad data! Try again.");
                            break;
                    }
                } while (!userDone);
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            finally
            {
                invDAL.CloseConnectin();
            }
        }
    }
}
