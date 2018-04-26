namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CaseHistorField")]
    public partial class CaseHistorField
    {
        [StringLength(50)]
        public string CHIDs { get; set; }

        [StringLength(50)]
        public string CHTypeIDs { get; set; }

        [Key]
        [StringLength(50)]
        public string FieldName { get; set; }
    }
}
