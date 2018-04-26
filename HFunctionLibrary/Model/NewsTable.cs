namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NewsTable")]
    public partial class NewsTable
    {
        [Key]
        public int NewsID { get; set; }

        [StringLength(255)]
        public string NewsTitle { get; set; }

        public short? IsMarquee { get; set; }

        public int? CreateUserID { get; set; }

        public DateTime? CreateDatetime { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDatetime { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndDatetime { get; set; }

        [StringLength(255)]
        public string Comments { get; set; }

        [StringLength(50)]
        public string AppendName { get; set; }

        [StringLength(255)]
        public string AppendFilePath { get; set; }

        public int? ReadCount { get; set; }

        public int? Seq { get; set; }

        public int? NewsAttrib { get; set; }
    }
}
