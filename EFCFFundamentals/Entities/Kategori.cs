using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCFFundamentals.Entities
{
    [Table("Kategoriler")]
    public class Kategori
    {
        [Key]
        public int KategoriId { get; set; }
        [Required]
        [StringLength(25)]
        [Column("Kategori Adı", TypeName = "varchar")]
        public string KategoriAdi { get; set; }
        public string Aciklama { get; set; }

        public virtual List<Urun> Urunler { get; set; } = new List<Urun>(); 
    }
}
