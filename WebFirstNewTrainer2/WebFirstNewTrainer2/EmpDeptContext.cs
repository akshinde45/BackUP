using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebFirstNewTrainer2
{
    public class EmpDeptContext:DbContext
    {
       //public EmpDeptContext() : base("NewDbEmp") { }
       
        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }
    }
}