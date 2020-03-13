namespace HocSummerNote.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class hocsummernoteDb : DbContext
    {
        public hocsummernoteDb()
            : base("name=hocsummernoteDb")
        {
        }

        public virtual DbSet<post> posts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
