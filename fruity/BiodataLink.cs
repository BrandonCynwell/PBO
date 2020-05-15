namespace fruity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BiodataLink : DbContext
    {
        public BiodataLink()
            : base("name=BiodataLink")
        {
        }

        public virtual DbSet<Table> Tables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
