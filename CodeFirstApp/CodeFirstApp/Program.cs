using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApp
{
    public class product
    {
        public int productID { get; set; }
        public int Name { get; set; }
        public int Price { get; set; }


    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class ProductDbContext : DbContext
    {
        public ProductDbContext() : base("ProductDbContext")
        {

        }

        protected DbSet<product> product { get; set; }
    }
}
