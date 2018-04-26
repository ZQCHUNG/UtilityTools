namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserTable")]
    public partial class UserTable
    {
        [Key]
        public int UserID { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(128)]
        public string Password { get; set; }

        [StringLength(50)]
        public string RealName { get; set; }

        public int? CreateUserID { get; set; }

        public short? UserStatus { get; set; }

        public int? UserAttrib { get; set; }

        public int? UserDepart { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(255)]
        public string Comments { get; set; }

        [StringLength(10)]
        public string PID { get; set; }

        [StringLength(50)]
        public string UserCode { get; set; }

        public DateTime? Birthday { get; set; }

        public short? Sex { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Profession { get; set; }

        [StringLength(20)]
        public string TelOffice { get; set; }

        [StringLength(20)]
        public string TelHome { get; set; }

        [StringLength(20)]
        public string MobilePhone { get; set; }

        [StringLength(20)]
        public string Fax { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        public short? PageSize { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? BeginTime { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EndTime { get; set; }

        [StringLength(10)]
        public string LoginType { get; set; }
    }
}
