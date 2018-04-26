namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemTable")]
    public partial class ItemTable
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FieldID { get; set; }

        [Key]
        [Column(Order = 1)]
        public int ItemID { get; set; }

        [StringLength(50)]
        public string ItemName { get; set; }

        public short? Status { get; set; }
    }
}
