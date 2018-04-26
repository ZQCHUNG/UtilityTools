namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MessageTable")]
    public partial class MessageTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MsgID { get; set; }

        public short? MsgSource { get; set; }

        public int? MsgGroupID { get; set; }

        [StringLength(50)]
        public string MsgText { get; set; }

        public short? MsgStatus { get; set; }

        public short? Seq { get; set; }
    }
}
