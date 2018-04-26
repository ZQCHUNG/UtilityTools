namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PageTable")]
    public partial class PageTable
    {
        [Key]
        public int PageID { get; set; }

        [StringLength(50)]
        public string PageName_Show { get; set; }

        [StringLength(50)]
        public string PageName { get; set; }

        [StringLength(50)]
        public string PageParentName { get; set; }

        public int? Seq { get; set; }

        public int? PageStatus { get; set; }
    }
}
