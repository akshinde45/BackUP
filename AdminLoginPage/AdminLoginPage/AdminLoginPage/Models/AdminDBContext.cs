using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AdminLoginPage.Models
{
    public class AdminDBContext:DbContext
    {
        public AdminDBContext(): base("AdminNewDb") { }

        public DbSet<AdminLogin> adminLogins { get; set; }

        public DbSet<AdminAddBook> AdminAddBooks { get; set; }
    }
}