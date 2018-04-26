namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CaseHistorTable5
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(1)]
        public string CHTypeCode { get; set; }

        [StringLength(50)]
        public string CHTypeName { get; set; }

        public short? Status { get; set; }

        public short? Seq { get; set; }
    }
}
