namespace AutoLotDAL_4._0.Migrations
{
    using AutoLotDAL_4._0.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AutoLotDAL_4._0.EF.AutoLotEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "AutoLotDAL_4._0.EF.AutoLotEntities";
        }

        protected override void Seed(AutoLotDAL_4._0.EF.AutoLotEntities context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var custumer = new List<Customer>
            {
                new Customer{FirstName = "Dave", LastName = "Berns"},
                new Customer{FirstName = "Steve", LastName = "Hagen"},
                new Customer{FirstName = "Pat", LastName = "Walton"},
                new Customer{FirstName = "Matt", LastName = "Libovsky" },
                new Customer{FirstName = "Bad", LastName = "Customer"}
            };
            custumer.ForEach(x => context.Customers.AddOrUpdate(c => new {c.FirstName, c.LastName},x));

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
            cars.ForEach(x => context.Inventory.AddOrUpdate(i => new { i.Make, i.Color, i.PetName }, x));

            var orders = new List<Order>
            {
                new Order {Car= cars[0], Customer = custumer[0]},
                new Order {Car= cars[1], Customer = custumer[1]},
                new Order {Car= cars[2], Customer = custumer[2]},
                new Order {Car= cars[3], Customer = custumer[3]}
            };
            orders.ForEach(x => context.Orders.AddOrUpdate(o => new { o.CarId, o.CustId }, x));

            context.CreditRisks.AddOrUpdate(c => new { c.FirstName, c.LastName},
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
