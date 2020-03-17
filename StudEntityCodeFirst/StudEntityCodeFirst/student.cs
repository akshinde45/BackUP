using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace StudEntityCodeFirst
{
    class student
    {
    [Key]
          public int Sid { get; set; }
        [Required]
            public string SName { get; set; }
            public double Sfees { get; set; }


        
    }
}
