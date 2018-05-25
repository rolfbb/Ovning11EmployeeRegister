namespace EmployeeRegister.Migrations
{
    using EmployeeRegister.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeRegister.DataAccessLayer.RegisterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataAccessLayer.RegisterContext db)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            db.Employees.AddOrUpdate(
                e => e.LastName,
                new Employee { FirstName = "Kalle", LastName = "Kula", Department = "Tools", Position = "Manager", Salary = 33000 },
                new Employee { FirstName = "Nigel", LastName = "Mansell", Department = "Management", Position = "Top Management", Salary = 44000 },
                new Employee { FirstName = "Christer", LastName = "Karlsson", Department = "Food", Position = "Floor", Salary = 27000 }
                );
        }
    }
}
