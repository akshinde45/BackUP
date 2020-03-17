namespace SecondPractMVC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEPARTMENT")]
    public partial class DEPARTMENT
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DEPARTMENT_ID { get; set; }

        [StringLength(40)]
        public string DEPT_NAME { get; set; }
    }
}
