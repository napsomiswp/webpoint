namespace NAPSOMIS_Webpoint.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ReferenceNoModel : DbContext
    {
        public ReferenceNoModel()
            : base("name=ReferenceNoModel")
        {
        }

        public virtual DbSet<ReferenceNo> ReferenceNos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReferenceNo>()
                .Property(e => e.Range)
                .IsUnicode(false);

            modelBuilder.Entity<ReferenceNo>()
                .Property(e => e.GeneratedRange)
                .IsUnicode(false);

            modelBuilder.Entity<ReferenceNo>()
                .Property(e => e.CurrentYear)
                .IsUnicode(false);

            modelBuilder.Entity<ReferenceNo>()
                .Property(e => e.GeneratedBy)
                .IsUnicode(false);
        }
    }
}
