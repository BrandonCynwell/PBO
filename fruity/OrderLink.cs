namespace fruity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OrderLink : DbContext
    {
        public OrderLink()
            : base("name=OrderLink1")
        {
        }

        public virtual DbSet<Pesan> Pesans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
