namespace CrudDemo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NorthwindDBModel : DbContext
    {
        public NorthwindDBModel()
            : base("name=NorthwindDBModel")
        {
        }

        public virtual DbSet<Region> Regions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Region>()
                .Property(e => e.RegionDescription)
                .IsFixedLength();
        }
    }
}
