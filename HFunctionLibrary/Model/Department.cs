namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Department")]
    public partial class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DepID { get; set; }

        [StringLength(20)]
        public string DepCode { get; set; }

        [StringLength(50)]
        public string DepName { get; set; }

        public short? Status { get; set; }

        [StringLength(255)]
        public string Comments { get; set; }
    }
}
