namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BurnTable")]
    public partial class BurnTable
    {
        public int ID { get; set; }

        public short? Status { get; set; }

        [StringLength(255)]
        public string DiskName { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? BurnTime { get; set; }

        [StringLength(255)]
        public string Comments { get; set; }

        public int? CaseCount { get; set; }

        public int? FileCount { get; set; }

        public int? FileLostCount { get; set; }

        public long? DiskSpace { get; set; }
    }
}
