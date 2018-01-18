using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AracYonetim.Entities.Enums;

namespace AracYonetim.Entities.Models
{
    [Table("Araclar")]
    public class Arac
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        //[Required]
        //[StringLength(100)]
        public string Model { get; set; }
        [Range(1850, 2100)]
        public int UretimYili { get; set; }
        public YakitTipleri YakitTipi { get; set; }
        public VitesTipleri VitesTipi { get; set; }
        public byte[] Fotograf { get; set; }
        public int MarkaId { get; set; }

        [ForeignKey("MarkaId")]
        public virtual Marka Markasi { get; set; }
        public override string ToString() => $"{this.Model} - {this.UretimYili} {this.YakitTipi}";
    }
}
