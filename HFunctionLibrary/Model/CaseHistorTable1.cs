namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CaseHistorTable1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CHID { get; set; }

        [StringLength(50)]
        public string CHName { get; set; }

        public int? MedRevID { get; set; }

        [StringLength(50)]
        public string HISMethod { get; set; }

        public short? Status { get; set; }

        public short? Seq { get; set; }

        [StringLength(20)]
        public string HSRange { get; set; }
    }
}
