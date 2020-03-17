using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityPractMVC.Models
{
    public class Department
    {
        [Key]
        public int Did { get; set; }
        [Required]
        public string Dname { get; set; }
        public decimal salary { get; set; }
    }
}