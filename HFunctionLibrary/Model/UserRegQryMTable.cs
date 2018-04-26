namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserRegQryMTable")]
    public partial class UserRegQryMTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RegQryID { get; set; }

        [StringLength(255)]
        public string RegQryName { get; set; }

        public int? UserID { get; set; }

        public DateTime? CreateDatetime { get; set; }

        public short? Status { get; set; }
    }
}
