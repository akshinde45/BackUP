using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SecondPractMVC.Models
{
    public class Employee
    {
        public int Eid { get; set; }
        [Display(Name ="Name")]
        public string EName { get; set; }
        public int Econtact { get; set; }

    }
}