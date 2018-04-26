namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CaseHistorTable2
    {
        [Key]
        public int CHFieldID { get; set; }

        [StringLength(50)]
        public string CHIDs { get; set; }

        [StringLength(50)]
        public string CHTypeIDs { get; set; }

        [StringLength(50)]
        public string FieldName { get; set; }

        public int? FieldType { get; set; }

        public int? FieldViewType { get; set; }

        [StringLength(255)]
        public string FieldMapping { get; set; }

        public int? FieldIsVisible { get; set; }

        [StringLength(50)]
        public string MappingHISTag { get; set; }

        [StringLength(50)]
        public string Extention { get; set; }
    }
}
