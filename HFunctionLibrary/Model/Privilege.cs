namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Privilege")]
    public partial class Privilege
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PrivID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short PrivSource { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PrivValue { get; set; }

        [StringLength(255)]
        public string PrivName { get; set; }

        public int? ParentID { get; set; }

        public int? LevelID { get; set; }

        public short? Seq { get; set; }

        [StringLength(255)]
        public string Comments { get; set; }
    }
}
