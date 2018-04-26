namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HISViewCtrl")]
    public partial class HISViewCtrl
    {
        [Key]
        public Guid HISVCID { get; set; }

        [Required]
        [StringLength(50)]
        public string PatNo { get; set; }

        public DateTime PermissTime { get; set; }
    }
}
