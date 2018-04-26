namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GroupTable")]
    public partial class GroupTable
    {
        [Key]
        public int GroupID { get; set; }

        [StringLength(50)]
        public string GroupName { get; set; }

        public int? Privilege { get; set; }

        [StringLength(255)]
        public string Comments { get; set; }
    }
}
