namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CaseTable")]
    public partial class CaseTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CaseID { get; set; }

        [StringLength(50)]
        public string CaseSN { get; set; }

        [StringLength(50)]
        public string CaseName { get; set; }

        public int? ClassID { get; set; }

        [StringLength(255)]
        public string KeyWord { get; set; }

        [StringLength(255)]
        public string Notation { get; set; }

        public int? CaseTypeID { get; set; }

        public int? CHID { get; set; }

        public int? CHFormID { get; set; }

        public int? CHTypeID { get; set; }

        public int? CDID { get; set; }

        public short? CaseStatus { get; set; }

        public short IsCheck { get; set; }

        [Required]
        [StringLength(255)]
        public string PatImgNo { get; set; }
    }
}
