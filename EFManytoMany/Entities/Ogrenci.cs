using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFManytoMany.Entities
{
    [Table("Ogrenciler")]
    public class Ogrenci
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Ad { get; set; }
        [Required]
        [StringLength(30)]
        public string Soyad { get; set; }
        [Column(TypeName = "date")]
        public DateTime DogumTarihi { get; set; }
        [NotMapped]
        public int Yas => DateTime.Now.Year - this.DogumTarihi.Year;
        public Cinsiyetler Cinsiyet { get; set; } = Cinsiyetler.Belirsiz;
        public override string ToString() => $"{Ad} {Soyad} - {Yas} {Cinsiyet.ToString().Substring(0, 1)}";

        public virtual List<Ders> Dersler { get; set; } = new List<Ders>();
    }

    public enum Cinsiyetler : byte
    {
        Erkek,
        Kadın,
        Belirsiz
    }
}
