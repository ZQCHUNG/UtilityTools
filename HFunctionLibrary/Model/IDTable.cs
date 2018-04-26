namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IDTable")]
    public partial class IDTable
    {
        [Key]
        [StringLength(50)]
        public string TableFieldName { get; set; }

        public int? TableFieldMaxID { get; set; }
    }
}
