using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace TryWebFirstEntityFramework
{
    class EmpDepartContext:DbContext
    {
        public EmpDepartContext() : base("EmpDepartDbContext"){ }

        public DbSet<Employee> employees { get; set; }

        public DbSet<Department> Departments { get; set; }
    }
}
