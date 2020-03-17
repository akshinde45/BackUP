using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityPractMVC.Models
{
    public class Employee
    {
        [Key]
       
        public int Eid { get; set; }
        [Required]
        public string Ename { get; set; }
    
        public string Designation { get; set; }
    }
}