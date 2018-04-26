namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogTable")]
    public partial class LogTable
    {
        [Key]
        public int LogID { get; set; }

        public int? UserID { get; set; }

        public DateTime? TransDatetime { get; set; }

        [StringLength(15)]
        public string TransIP { get; set; }

        public int? TransResult { get; set; }

        [StringLength(350)]
        public string Comments { get; set; }

        public int? CaseID { get; set; }

        public int? FileID { get; set; }

        [StringLength(255)]
        public string FilePath { get; set; }

        public short? LogSource { get; set; }

        [StringLength(50)]
        public string CallUserName { get; set; }
    }
}
