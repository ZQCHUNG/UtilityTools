namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FileTable")]
    public partial class FileTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FileID { get; set; }

        public int CaseID { get; set; }

        public short? Status { get; set; }

        public int? DocSource { get; set; }

        public int? DocAttrib { get; set; }

        [StringLength(50)]
        public string FVersion { get; set; }

        public int? CreateUserID { get; set; }

        public int? CreateDepID { get; set; }

        public DateTime? CreateDatetime { get; set; }

        public DateTime? ScanDatetime { get; set; }

        public long? FileSize { get; set; }

        [StringLength(255)]
        public string FilePath { get; set; }

        [StringLength(255)]
        public string Comments { get; set; }

        [StringLength(255)]
        public string XMLPath { get; set; }

        public int? BurnID { get; set; }

        public int? PageCount { get; set; }

        public int? CheckUserID { get; set; }

        [StringLength(255)]
        public string PDFPath { get; set; }

        public short IsThumbed { get; set; }

        public DateTime? CheckDatetime { get; set; }

        [StringLength(15)]
        public string CheckUserIP { get; set; }
    }
}
