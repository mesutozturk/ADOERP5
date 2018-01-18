namespace EFCFFundamentals.ViewModels
{
    public class UrunViewModel
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public decimal? Fiyat { get; set; }
        public short Stok { get; set; }
        public string KategoriAdi { get; set; }
        public override string ToString() => $"{KategoriAdi} {UrunAdi}: {Fiyat:c2} - Kalan: {Stok}";
    }
}
