using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFManytoMany.Entities
{
    [Table("Dersler")]
    public class Ders
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string DersAdi { get; set; }
        [Range(0, 10)]
        public int Kredi { get; set; } // bu ve bunun gibi tamsayı prop.lerin maximum ve minimum değerini nasıl ayarlayabiliriz?
        public override string ToString() => $"{DersAdi} - {Kredi}";

        public virtual List<Ogrenci> Ogrenciler { get; set; } = new List<Ogrenci>();
    }
}
