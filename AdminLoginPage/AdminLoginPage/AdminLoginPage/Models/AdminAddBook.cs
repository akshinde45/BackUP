using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminLoginPage.Models
{
    public class AdminAddBook
    {
        
        
        public int id { get; set; }
        public string Book_Name { get; set; }
        public string author { get; set; }
        public double price { get; set; }
    }
}