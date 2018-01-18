using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AracYonetim.Entities.Models
{
    [Table("Markalar")]
    public class Marka
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string MarkaAdi { get; set; }
        [Range(1850, 2100, ErrorMessage = "Kurulus Yılı 1850-2100 arasında olabilir")]
        public int KurulusYili { get; set; }
        public string Ulke { get; set; }
        public string Kurucusu { get; set; }
        public byte[] Logo { get; set; } //varbinary

        public virtual List<Arac> Araclar { get; set; } = new List<Arac>();
        public override string ToString() => $"{this.MarkaAdi}";

        public string Nihat { get; set; }
    }
}
