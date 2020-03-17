using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdminLoginPage.Models
{
    public class AdminLogin
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string username { get; set; }
        public string password { get; set; }
        public string LoginErrorMessage { get;  set; }
    }
}