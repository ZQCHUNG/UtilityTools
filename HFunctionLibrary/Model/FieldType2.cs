namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FieldType2
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CaseID { get; set; }

        [StringLength(50)]
        public string DocName1 { get; set; }

        [StringLength(50)]
        public string DocName2 { get; set; }

        [StringLength(255)]
        public string DocName3 { get; set; }

        [StringLength(255)]
        public string DocName4 { get; set; }

        public DateTime? DocName5 { get; set; }

        public DateTime? DocName6 { get; set; }

        [StringLength(255)]
        public string DocName7 { get; set; }

        [StringLength(50)]
        public string DocName8 { get; set; }

        [StringLength(50)]
        public string DocName9 { get; set; }

        public DateTime? DocName10 { get; set; }

        public DateTime? DocName11 { get; set; }

        public DateTime? DocName12 { get; set; }

        [StringLength(50)]
        public string DocName13 { get; set; }

        [StringLength(50)]
        public string DocName14 { get; set; }

        [StringLength(50)]
        public string DocName15 { get; set; }

        [StringLength(50)]
        public string DocName16 { get; set; }

        [StringLength(50)]
        public string DocName17 { get; set; }

        [StringLength(50)]
        public string DocName18 { get; set; }

        [StringLength(50)]
        public string DocName19 { get; set; }

        public DateTime? DocName20 { get; set; }

        [StringLength(50)]
        public string DocName21 { get; set; }

        [StringLength(50)]
        public string DocName22 { get; set; }

        public DateTime? DocName23 { get; set; }

        public DateTime? DocName24 { get; set; }

        public DateTime? DocName25 { get; set; }

        public DateTime? DocName26 { get; set; }

        public DateTime? DocName27 { get; set; }

        [StringLength(50)]
        public string DocName28 { get; set; }

        [StringLength(255)]
        public string DocName29 { get; set; }

        [StringLength(50)]
        public string DocName30 { get; set; }

        public DateTime? DocName31 { get; set; }
    }
}
