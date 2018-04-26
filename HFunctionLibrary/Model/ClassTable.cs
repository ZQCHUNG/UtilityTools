namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClassTable")]
    public partial class ClassTable
    {
        [Key]
        public int ClassID { get; set; }

        public int? ParentID { get; set; }

        public int? LevelID { get; set; }

        [Required]
        [StringLength(50)]
        public string ClassName { get; set; }

        public short? Seq { get; set; }

        public short? Status { get; set; }

        public int? OwnerID { get; set; }
    }
}
