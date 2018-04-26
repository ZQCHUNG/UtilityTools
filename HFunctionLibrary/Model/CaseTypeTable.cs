namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CaseTypeTable")]
    public partial class CaseTypeTable
    {
        [Key]
        public int CaseTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string CaseTypeName { get; set; }

        [Required]
        [StringLength(50)]
        public string CaseTypeComment { get; set; }

        public short? Seq { get; set; }

        public short? Status { get; set; }
    }
}
