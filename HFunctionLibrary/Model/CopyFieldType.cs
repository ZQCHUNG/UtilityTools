namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CopyFieldType")]
    public partial class CopyFieldType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CpFieldID { get; set; }

        [Required]
        [StringLength(50)]
        public string FieldName { get; set; }

        [Required]
        [StringLength(50)]
        public string FieldComment { get; set; }

        public short? FieldType { get; set; }

        public short? FieldLength { get; set; }

        [StringLength(50)]
        public string FieldDefaultValue { get; set; }

        public short? FieldViewType { get; set; }

        public short? FieldAttrib { get; set; }

        public short? Status { get; set; }

        public short? Seq { get; set; }

        public int? CaseTypeID { get; set; }

        public short? IsModifyData { get; set; }

        public short? FieldViewTBMode { get; set; }

        public short? FieldViewTBWidth { get; set; }

        public short? FieldViewTBHeight { get; set; }
    }
}
