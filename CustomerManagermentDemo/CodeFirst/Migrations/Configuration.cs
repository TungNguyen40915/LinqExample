namespace CodeFirst.Migrations
{
    using CodeFirst.Entity;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirst.CodeFirstContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirst.CodeFirstContext context)
        {
            context.CustomerType.AddOrUpdate(
                c => c.Name,   // Use Name (or some other unique field) instead of Id
                new CustomerType() { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, CreateBy = "Seed data", Name = "NEW" },
                new CustomerType() { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, CreateBy = "Seed data", Name = "BRONZE" },
                new CustomerType() { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, CreateBy = "Seed data", Name = "SILVER" },
                new CustomerType() { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, CreateBy = "Seed data", Name = "GOLD" });

            context.SaveChanges();

            var CustomerTypes = context.CustomerType.ToList();

            context.Customer.AddOrUpdate(
                c => c.Name,   // Use Name (or some other unique field) instead of Id
                new Customer()
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    CreateBy = "Seed data",
                    Name = "NGUYEN BA TUNG",
                    Address = "LONG AN",
                    PhoneNumber = "0909090909",
                    Type = CustomerTypes[0]
                },
                new Customer()
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    CreateBy = "Seed data",
                    Name = "TRAN HOAI NAM",
                    Address = "VINH LONG",
                    PhoneNumber = "0909090909",
                    Type = CustomerTypes[1]
                },
                new Customer()
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    CreateBy = "Seed data",
                    Name = "NGO NHAT DO",
                    Address = "VINH PHUC",
                    PhoneNumber = "0909090909",
                    Type = CustomerTypes[2]
                },
                new Customer()
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    CreateBy = "Seed data",
                    Name = "NGUYEN HOAI THU",
                    Address = "TP.HO CHI MINH",
                    PhoneNumber = "0909090909",
                    Type = CustomerTypes[3]
                });
            context.SaveChanges();
        }
    }
}
