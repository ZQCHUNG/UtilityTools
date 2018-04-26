namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClientInfo")]
    public partial class ClientInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DepID { get; set; }

        [Required]
        [StringLength(255)]
        public string HISWSUrl { get; set; }

        [Required]
        [StringLength(50)]
        public string WMFileRGB { get; set; }

        [Required]
        [StringLength(50)]
        public string WMFileGray { get; set; }

        [Required]
        [StringLength(50)]
        public string WMFileBW { get; set; }

        [Required]
        [StringLength(50)]
        public string WebPDFSignSetting { get; set; }

        [Required]
        [StringLength(50)]
        public string FtpPDFSignSetting { get; set; }
    }
}
