namespace fruity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FruipediaLink : DbContext
    {
        public FruipediaLink()
            : base("name=FruipediaLink")
        {
        }

        public virtual DbSet<fruit> fruits { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
