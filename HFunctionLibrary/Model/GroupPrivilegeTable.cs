namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GroupPrivilegeTable")]
    public partial class GroupPrivilegeTable
    {
        [Key]
        public int GroupPrivilegeID { get; set; }

        public int PageID { get; set; }

        public int GroupID { get; set; }
    }
}
