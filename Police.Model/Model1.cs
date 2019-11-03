namespace Police.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        static void Main(string[] args)
        {

        }
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<search_outcomes> search_outcomes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<search_outcomes>()
                .Property(e => e.crime_id)
                .IsUnicode(false);

            modelBuilder.Entity<search_outcomes>()
                .Property(e => e.reported_by)
                .IsUnicode(false);

            modelBuilder.Entity<search_outcomes>()
                .Property(e => e.falls_within)
                .IsUnicode(false);

            modelBuilder.Entity<search_outcomes>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<search_outcomes>()
                .Property(e => e.lsoa_code)
                .IsUnicode(false);

            modelBuilder.Entity<search_outcomes>()
                .Property(e => e.context)
                .IsUnicode(false);
        }
    }
}
