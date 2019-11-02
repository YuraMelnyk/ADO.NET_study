using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotConsoleApp;
using System.Data.Entity;

namespace AutoLotConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Work with ADO.Net EF***********");
            Console.WriteLine("Enter Id to Delete car:");
            int carIdToDelete = int.Parse(Console.ReadLine().ToString());
            RemoveRecord(carIdToDelete);
            //int carId = AddNewRecords();
            //Console.WriteLine(carId);
            //WorkWithLinqQueries();
            PrintAllInventory();
            Console.ReadLine();
        }

        private static int AddNewRecords()
        {
            using(var context = new AutoLotEntities())
            {
                try
                {
                    Console.WriteLine("Enter new car:");
                    Console.WriteLine("Make:");
                    string strMake = Console.ReadLine().ToString();
                    Console.WriteLine("Color:");
                    string strColor = Console.ReadLine().ToString();
                    Console.WriteLine("PetName:");
                    string strPetName = Console.ReadLine().ToString();

                    var car = new Car() { Make = strMake, Color = strColor, PetName = strPetName };
                    context.Cars.Add(car);
                    context.SaveChanges();
                    return car.CarId;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.InnerException.Message);
                    return 0;
                }
            }
        }

        private static void PrintAllInventory()
        {
            try
            {
                using (var context = new AutoLotEntities())
                {
                    foreach (Car c in context.Cars)
                    {
                        Console.WriteLine(c);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        private static void WorkWithLinqQueries()
        {
            using (var context = new AutoLotEntities())
            {
                var colorsMakes = from item in context.Cars select new { item.Color, item.Make };
                foreach (var item in colorsMakes)
                {
                    Console.WriteLine(item);
                }

                var blackCars = from item in context.Cars where item.Color == "Black" select item;
                foreach (var item in blackCars)
                {
                    Console.WriteLine(item);
                }
            }
        }

        private static void RemoveRecord(int carId)
        {
            using (var context = new AutoLotEntities())
            {
                Car carToDelete = context.Cars.Find(carId);
                if (carToDelete != null)
                {
                    context.Cars.Remove(carToDelete);
                    context.SaveChanges();
                }
            }
        }

        private static void UpdateRecords(int carId)
        {
            using (var context = new AutoLotEntities())
            {
                Car carToUpdate = context.Cars.Find(carId);
                if (carToUpdate!= null)
                {
                    Console.WriteLine(context.Entry(carToUpdate).State);
                    carToUpdate.Color = "Blue";
                    Console.WriteLine(context.Entry(carToUpdate).State);
                    context.SaveChanges();
                }
            }
        }
    }
}
