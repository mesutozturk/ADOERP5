using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCFFundamentals.Entities
{
    [Table("Siparisler")]
    public class Siparis
    {
        [Key]
        public int SiparisId { get; set; }

        public DateTime SiparisTarihi { get; set; } = DateTime.Now;
        public DateTime? TeslimTarihi { get; set; }
        public int TedarikciId { get; set; }
        public decimal KargoFiyati { get; set; } = 0;


        [ForeignKey("TedarikciId")]
        public virtual Tedarikci Tedarikci { get; set; }

        public virtual List<SiparisDetay> SiparisDetaylar { get; set; } = new List<SiparisDetay>();
    }
}
