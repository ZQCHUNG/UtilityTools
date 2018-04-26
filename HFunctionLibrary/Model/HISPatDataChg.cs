namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HISPatDataChg")]
    public partial class HISPatDataChg
    {
        [Key]
        [Column(Order = 0)]
        public DateTime ChgDatetime { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CaseID { get; set; }

        [StringLength(50)]
        public string PatNo { get; set; }

        [StringLength(50)]
        public string PID { get; set; }

        [StringLength(50)]
        public string PName { get; set; }

        [StringLength(255)]
        public string Tel { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        public DateTime? BirDate { get; set; }

        public DateTime? DelDate { get; set; }

        [StringLength(255)]
        public string Email { get; set; }
    }
}
