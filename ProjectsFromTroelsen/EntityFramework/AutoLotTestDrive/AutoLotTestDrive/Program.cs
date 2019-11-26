using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotDAL_4._0;
using AutoLotDAL_4._0.EF;
using AutoLotDAL_4._0.Models;
using AutoLotDAL_4._0.Repos;

namespace AutoLotTestDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DataInitializer());
            Console.WriteLine("*********Work with ADO.NET EF Code First************");
            var car1 = new Inventory() { Make = "VW", Color = "Blue", PetName = "Blummy" };
            var car2 = new Inventory() { Make = "VW", Color = "Black", PetName = "Ned" };
            AddNewRecord(car1);
            AddNewRecord(car2);
            AddNewRecords(new List<Inventory> { car1, car2 });
            UpdateRecord(car1.CarId);
            PrintAllInventory();
            ShowAllOrders();

            PrintAllCustumersAndCreditRisks();
            var custumerRepo = new CustomerRepo();
            var custumer = custumerRepo.GetOne(4);
            custumerRepo.Context.Entry(custumer).State = EntityState.Detached;
            var risk = MakeCustumerARisk(custumer);
            PrintAllCustumersAndCreditRisks();

            Console.ReadLine();
        }
        private static void PrintAllInventory()
        {
            Console.WriteLine("******All Inventory******");
            using (var repo = new InventoryRepo())
            {
                foreach (Inventory c in repo.GetAll())      
                {
                    Console.WriteLine(c);
                }
            }
        }

        private static void AddNewRecord(Inventory car)
        {
            using (var repo = new InventoryRepo())
            {
                repo.Add(car);
            }
        }
         private static void AddNewRecords(IList<Inventory> cars)
        {
            using (var repo = new InventoryRepo())
            {
                repo.AddRange(cars);
            }
        }

        private static void UpdateRecord(int carId)
        {
            using (var repo = new InventoryRepo())
            {
                var carToUpdate = repo.GetOne(carId);
                if (carToUpdate != null)
                {
                    Console.WriteLine( "******************************************");
                    Console.WriteLine("Before change:" + repo.Context.Entry(carToUpdate).State);
                    carToUpdate.Color = "Pink";
                    Console.WriteLine("After change:" + repo.Context.Entry(carToUpdate).State);
                    repo.Save(carToUpdate);
                    Console.WriteLine("After save:" + repo.Context.Entry(carToUpdate).State);
                }
            }
        }

        private static void ShowAllOrders()
        {
            using (var repo = new OrderRepo())
            {
                Console.WriteLine("*****Pending Orders********");
                foreach (var item in repo.GetAll())
                {
                    Console.WriteLine($"->{item.Customer.FirstName} is waiting on {item.Car.PetName}");
                }
            }
        }

        private static CreditRisk MakeCustumerARisk(Customer customer)
        {
            using (var context = new AutoLotEntities())
            {
                context.Customers.Attach(customer);
                context.Customers.Remove(customer);
                var creditRisk = new CreditRisk()
                {
                    FirstName = customer.FirstName,
                    LastName = customer.LastName
                };
                context.CreditRisks.Add(creditRisk);
                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    Console.WriteLine(ex);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                return creditRisk;
            }
        }
        private static void PrintAllCustumersAndCreditRisks()
        {
            Console.WriteLine("*******Custumers*******");
            using (var repo = new CustomerRepo())
            {
                foreach (var cust in repo.GetAll())
                {
                    Console.WriteLine($"->{cust.FirstName} {cust.LastName} is a Custumer.");
                }
            }
            Console.WriteLine("********Credi Risk**********");
            using (var repo = new CreditRiskRepo())
            {
                foreach (var risk in repo.GetAll())
                {
                    Console.WriteLine($"{risk.FirstName} {risk.LastName} is a Credit Risk.");
                }
            }
        }
    }
}
