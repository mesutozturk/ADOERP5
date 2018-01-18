using System.Data.Entity;
using EFManytoMany.Entities;

namespace EFManytoMany.DAL
{
    public class MyContext : DbContext
    {
        public MyContext()
        : base("name=MyCon")
        {

        }

        public virtual DbSet<Ogrenci> Ogrenciler { get; set; }
        public virtual DbSet<Ders> Dersler { get; set; }
    }
}
