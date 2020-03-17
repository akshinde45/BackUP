using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TryWebFirstEntityFramework
{
    class Department
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int DId { get; set; }
        [Required]
        public string DName { get; set; }
        public string DAddress { get; set; }
    }
}
