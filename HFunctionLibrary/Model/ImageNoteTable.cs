namespace HFunctionLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImageNoteTable")]
    public partial class ImageNoteTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NoteID { get; set; }

        public int? CaseID { get; set; }

        public int? FileID { get; set; }

        public int? PageIndex { get; set; }

        public int? NoteType { get; set; }

        public int? NoteLeft { get; set; }

        public int? NoteRight { get; set; }

        public int? NoteTop { get; set; }

        public int? NoteBottom { get; set; }

        public int? NoteColor { get; set; }

        [StringLength(255)]
        public string NoteText { get; set; }

        public int? Thickness { get; set; }

        public int? CreateUserID { get; set; }

        public DateTime? CreateDatetime { get; set; }

        public short? Status { get; set; }
    }
}
