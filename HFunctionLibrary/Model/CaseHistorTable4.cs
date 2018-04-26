namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CaseHistorTable4
    {
        [Key]
        public int CHFormID { get; set; }

        [StringLength(50)]
        public string CHFormName { get; set; }

        public int ParentCHID { get; set; }

        public int CHTypeID { get; set; }

        [StringLength(10)]
        public string CHFormHISID { get; set; }

        public short? Status { get; set; }

        public short? Seq { get; set; }
    }
}
