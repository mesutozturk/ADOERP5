using System;

namespace EFCFFundamentals.ViewModels
{
    public class SiparisViewModel
    {
        public int SiparisNo { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public DateTime? TeslimTarihi { get; set; }
        public decimal KargoTutari { get; set; }
        public decimal ToplamSiparisTutari { get; set; }
    }
}
