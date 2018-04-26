namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FieldTypeName")]
    public partial class FieldTypeName
    {
        [Key]
        public int FieldID { get; set; }

        [Required]
        [StringLength(50)]
        public string FieldName { get; set; }

        [Required]
        [StringLength(50)]
        public string FieldComment { get; set; }

        public int? FieldType { get; set; }

        public short? FieldLength { get; set; }

        [StringLength(50)]
        public string FieldDefaultValue { get; set; }

        public int? FieldViewType { get; set; }

        public int? FieldAttrib { get; set; }

        public short? Status { get; set; }

        public int? Seq { get; set; }

        public int? CaseTypeID { get; set; }

        public short? IsModifyData { get; set; }

        public short? FieldViewTBMode { get; set; }

        public short? FieldViewTBWidth { get; set; }

        public short? FieldViewTBHeight { get; set; }
    }
}
