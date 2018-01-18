using System;

namespace EFCFFundamentals.ViewModels
{
    public class SepetViewModel
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public short Adet { get; set; } = 1;
        public decimal Fiyat { get; set; } = 0;
        public decimal Indirim { get; set; } = 0;
        public decimal Toplam => Adet * Fiyat * Convert.ToDecimal(1 - Indirim);
        public override string ToString() => $"{UrunAdi} {Adet}x{Fiyat:c2} = {Toplam:c2}";
    }
}
