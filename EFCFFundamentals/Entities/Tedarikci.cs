using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCFFundamentals.Entities
{
    [Table("Tedarikciler")]
    public class Tedarikci
    {
        public Tedarikci()
        {
            this.Urunler = new List<Urun>();
            this.Siparisler=new List<Siparis>();
        }
        [Key]
        public int TedarikciId { get; set; }
        [Required]
        [StringLength(100)]
        public string FirmaAdi { get; set; }
        [Required]
        [StringLength(11)]
        public string Telefon { get; set; }

        public virtual List<Urun> Urunler { get; set; }
        public virtual List<Siparis> Siparisler { get; set; }
    }
}
