namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserRegQryDTable")]
    public partial class UserRegQryDTable
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RegQryID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FieldID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string OperationText { get; set; }

        [StringLength(255)]
        public string Keyword { get; set; }
    }
}
