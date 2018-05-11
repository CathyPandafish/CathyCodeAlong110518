using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVC_CathyCodeAlong_110518.Models;

namespace MVC_CathyCodeAlong_110518.DataAccessLayer
{
    public class RegisterContext: DbContext
    {
        public RegisterContext(): base("CathyCodeAlong-110518")
        {

        }
        public DbSet<Employee> Employees { get; set; } // tables of employees
    }
}