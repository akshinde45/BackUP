using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstPractWebMVC.Models
{
    public class Student
    {
       
        public int StudentId { get;  set; }
        [Display(Name="name")]
        public string StudentName { get; set; }

        public int Age { get; set; }
    }
}