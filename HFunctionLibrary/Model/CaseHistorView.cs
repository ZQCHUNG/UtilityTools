namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CaseHistorView")]
    public partial class CaseHistorView
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CHViewID { get; set; }

        public int CaseID { get; set; }

        public int AppUserID { get; set; }

        public DateTime? AppDatetime { get; set; }

        public int? CHVRnID { get; set; }

        public short? CHVRnDays { get; set; }

        [StringLength(20)]
        public string UserTel { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DeadLineDate { get; set; }

        public short? IsSave { get; set; }

        public short? IsPrint { get; set; }

        public int? AuditUserID { get; set; }

        public DateTime? AuditDatetime { get; set; }

        [StringLength(255)]
        public string PDFPath { get; set; }

        public short? Status { get; set; }

        [StringLength(255)]
        public string Comments { get; set; }
    }
}
