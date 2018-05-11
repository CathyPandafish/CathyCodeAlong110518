namespace MVC_CathyCodeAlong_110518.Migrations
{
    using MVC_CathyCodeAlong_110518.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC_CathyCodeAlong_110518.DataAccessLayer.RegisterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVC_CathyCodeAlong_110518.DataAccessLayer.RegisterContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            Employee person = new Employee()
            {
                FirstName = "Per",
                LastName = "Svensson",
                Salary = 20000 ,
                Department = "HR",
                Position = "Assistant"
            };
            context.Employees.AddOrUpdate(t=> t.FirstName,person);
        }
    }
}
