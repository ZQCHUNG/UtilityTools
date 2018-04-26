namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StorePathTable")]
    public partial class StorePathTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreID { get; set; }

        [StringLength(255)]
        public string Path { get; set; }

        public short? Status { get; set; }

        public short? Seq { get; set; }

        public long? DiskMinSize { get; set; }

        [StringLength(255)]
        public string Comments { get; set; }

        [StringLength(50)]
        public string FUserName { get; set; }

        [StringLength(50)]
        public string FPassword { get; set; }

        [StringLength(50)]
        public string StoreIP { get; set; }

        public short? StoreAttrib { get; set; }
    }
}
