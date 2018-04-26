namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CaseHistorViewRn")]
    public partial class CaseHistorViewRn
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CHVRnID { get; set; }

        [StringLength(100)]
        public string CHVRnDescr { get; set; }

        public short? CHVRnDays { get; set; }

        public short? Status { get; set; }
    }
}
