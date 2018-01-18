using EFCFFundamentals.Entities;
using System.Data.Entity;

namespace EFCFFundamentals.DAL
{
    public class MyContext : DbContext
    {
        public MyContext()
            : base("name=MyCon")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //fluent api 
            modelBuilder.Entity<Urun>()
                .Property(x => x.Fiyat)
                .HasPrecision(10, 3);

            modelBuilder.Entity<Siparis>()
                .Property(x => x.KargoFiyati)
                .HasPrecision(10, 4);

            modelBuilder.Entity<SiparisDetay>()
                .Property(x => x.Fiyat)
                .HasPrecision(10, 4);
            modelBuilder.Entity<SiparisDetay>()
                .Property(x => x.Indirim)
                .HasPrecision(5, 4);

            //fluent api 
        }
        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<Urun> Urunler { get; set; }
        public virtual DbSet<Tedarikci> Tedarikciler { get; set; }
        public virtual DbSet<SiparisDetay> SiparisDetaylar { get; set; }
        public virtual DbSet<Siparis> Siparisler { get; set; }
    }
}
