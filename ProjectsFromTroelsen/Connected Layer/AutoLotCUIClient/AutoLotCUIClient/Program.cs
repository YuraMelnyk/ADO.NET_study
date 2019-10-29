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
                ShowInstructions();
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

        private static void ShowInstructions()
        {
            WriteLine("I: Insert a new car.");
            WriteLine("U: Updates an existing car.");
            WriteLine("D: Delete an existing car.");
            WriteLine("L: Lists current inventory.");
            WriteLine("S: Shows these instructions.");
            WriteLine("P: Looks up pet name.");
            WriteLine("Q: Quits program.");
        }

        private static void ListInventory(InventoryDAL invDAL)
        {
            DataTable dt = invDAL.GetAllInventoryAsDataTable();
            DisplyTable(dt);
        }

        private static void DisplyTable(DataTable dt)
        {
            for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
            {
                Write($"{dt.Columns[curCol].ColumnName}\t");
            }
            WriteLine("\n------------------------------------");
            for (int curRow = 0; curRow < dt.Rows.Count; curRow++)
            {
                for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
                {
                    Write($"{dt.Rows[curRow][curCol]}\t");
                }
                WriteLine();
            }
        }

        private static void DeleteCar(InventoryDAL invDAL)
        {
            Write("Enter ID of Car to delete:");
            int id = int.Parse(ReadLine() ?? "0");
            try
            {
                invDAL.DeleteCar(id);
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }

        private static void InsertNewCar(InventoryDAL invDAL)
        {
            Write("Enter Car ID:");
            var newCarId = int.Parse(ReadLine() ?? "0");
            Write("Enter Car Color:");
            var newCarColor = ReadLine();
            Write("Enter Car Make");
            var newCarMake = ReadLine();
            Write("Enter Pet Name: ");
            var newCarPetName = ReadLine();
            invDAL.InsertAuto(newCarId, newCarColor, newCarMake, newCarPetName);
        }

        private static void UpdateCarPetName(InventoryDAL invDAL)
        {
            Write("Enter Car ID:");
            var carID = int.Parse(ReadLine() ?? "0");
            Write("Enter New Car Pet Name:");
            var newCarPetName = ReadLine();
            Write("Enter New Car Color:");
            var newCarColor = ReadLine();
            invDAL.UpdateCar(carID, newCarPetName, newCarColor);
        }

        private static void LookUpPetName(InventoryDAL invDAL)
        {
            Write("Enter ID of Car to look up:");
            int id = int.Parse(ReadLine() ?? "0");
            WriteLine($"PetName of {id} is {invDAL.LookUpPetName(id).TrimEnd()}.");
        }
    }


   
}
