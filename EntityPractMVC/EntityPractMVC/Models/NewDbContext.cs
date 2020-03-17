using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace EntityPractMVC.Models
{
    public class NewDbContext:DbContext
    {
      public NewDbContext() : base("MyEntityDatabase") { }
        
        public DbSet<Employee> employees { get; set; }

        public DbSet <Department> departments { get; set; }
    }
}