using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AutoLotDAL_4._0.Models;

namespace AutoLotDAL_4._0.EF
{
    public class DataInitializer : DropCreateDatabaseAlways<AutoLotEntities>
    {
        protected override void Seed(AutoLotEntities context)
        {
            var custumer = new List<Customer>
            {
                new Customer{FirstName = "Dave", LastName = "Berns"},
                new Customer{FirstName = "Steve", LastName = "Hagen"},
                new Customer{FirstName = "Pat", LastName = "Walton"},
                new Customer{FirstName = "Matt", LastName = "Libovsky" },
                new Customer{FirstName = "Bad", LastName = "Customer"}
            };
            custumer.ForEach(x => context.Customers.Add(x));

            var cars = new List<Inventory>
            {
                new Inventory {Make="VW", Color = "Black", PetName = "Zippy"},
                new Inventory {Make="VW", Color = "Grey", PetName = "Yogy"},
                new Inventory {Make="BMW", Color = "Black", PetName = "Bimer"},
                new Inventory {Make="BMW", Color = "Black", PetName = "Hank"},
                new Inventory {Make="Pinto", Color = "Pink", PetName = "Pinky"},
                new Inventory {Make="Yugo", Color = "Black", PetName = "Pete"},
                new Inventory {Make="Ford", Color = "Green", PetName = "Rusty"},
                new Inventory {Make="Ford", Color = "Brown", PetName = "Browny"},
                new Inventory {Make="VAZ", Color = "Red", PetName = "Cent"},
                new Inventory {Make="Toyota", Color = "Yellow", PetName = "Clunker"}
            };
            cars.ForEach(x => context.Inventory.Add(x));

            var orders = new List<Order>
            {
                new Order {Car= cars[0], Customer = custumer[0]},
                new Order {Car= cars[1], Customer = custumer[1]},
                new Order {Car= cars[2], Customer = custumer[2]},
                new Order {Car= cars[3], Customer = custumer[3]}
            };
            orders.ForEach(x => context.Orders.Add(x));

            context.CreditRisks.Add(
                new CreditRisk
                {
                    CustId = custumer[4].CustId,
                    FirstName = custumer[4].FirstName,
                    LastName = custumer[4].LastName,
                });
            context.SaveChanges();
        }
    }
}
    