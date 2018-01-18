using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCFFundamentals.Entities
{
    [Table("Urunler")]
    public class Urun
    {
        [Key]
        public int UrunId { get; set; }
        [Required]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "Ürün adı 2-40 karakter aralığında olmalıdır")]
        [Index(IsUnique = true)]
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; } = 0;
        public short Stok { get; set; } = 0;
        public DateTime EklenmeZamani { get; set; } = DateTime.Now;
        public int KategoriId { get; set; }
        public int? TedarikciId { get; set; } 

        [ForeignKey("KategoriId")]
        public virtual Kategori Kategori { get; set; }
        [ForeignKey("TedarikciId")]
        public virtual Tedarikci Tedarikci { get; set; }
        public virtual List<SiparisDetay> SiparisDetaylar { get; set; }= new List<SiparisDetay>();
    }
}
