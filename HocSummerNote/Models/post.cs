namespace HocSummerNote.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("post")]
    public partial class post
    {
        public long id { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(100)]
        public string Metattitle { get; set; }

        public string ShortInfo { get; set; }

        public string Content { get; set; }

        public bool? Active { get; set; }

        public DateTime? PostedDate { get; set; }
    }
}
