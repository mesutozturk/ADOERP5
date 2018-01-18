using System.Data.Entity;
using AracYonetim.Entities.Models;

namespace AracYonetim.DAL
{
    public class MyContext : DbContext
    {
        public MyContext()
            : base("name=MyCon") { }

        public virtual DbSet<Marka> Markalar { get; set; }
        public virtual DbSet<Arac> Araclar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Fluent-API vs.vs.
            modelBuilder.Entity<Arac>()
                .Property(x => x.Model)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
