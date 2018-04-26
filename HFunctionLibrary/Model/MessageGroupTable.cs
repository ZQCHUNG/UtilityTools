namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MessageGroupTable")]
    public partial class MessageGroupTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MsgGroupID { get; set; }

        [StringLength(50)]
        public string MsgGroupName { get; set; }

        public short? MsgGroupStatus { get; set; }
    }
}
