using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace EmployeeRegister.DataAccessLayer
{
    public class RegisterContext : DbContext
    {
        public DbSet<Models.Employee> Employees { get; set; }

        public RegisterContext() : base("DefaultConnection")
        {
        }
    }
}