namespace SecondPractMVC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EMPLOYEE")]
    public partial class EMPLOYEE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EMP_ID { get; set; }

        [Required]
        [StringLength(40)]
        public string EMP_NAME { get; set; }

        [Column(TypeName = "money")]
        public decimal SALARY { get; set; }

        public int DEPARTMENT_ID { get; set; }

        public virtual DEPART DEPART { get; set; }
    }
}
