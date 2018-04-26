namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SystemTable")]
    public partial class SystemTable
    {
        [Key]
        [StringLength(50)]
        public string SystemName { get; set; }

        [StringLength(200)]
        public string SystemComment { get; set; }
    }
}
