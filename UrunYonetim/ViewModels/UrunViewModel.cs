namespace UrunYonetim.ViewModels
{
    public class UrunViewModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public string CategoryName { get; set; }
        public override string ToString() => $"{CategoryName} {ProductName}: {UnitPrice:c2} - Kalan:{UnitsInStock ?? 0}";
    }
}
