using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TryWebFirstEntityFramework
{
    class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public  int EId { get; set; }
        [Required]
        public string EName { get; set; }
        public string EDesignation { get; set; }
        public double ESalary { get; set; }
        //foregin  key
        [Display(Name ="Department")]
        public virtual int DId { get; set; }
        [ForeignKey("DId")]
        public virtual Department Departments { get; set; }
    }
}
