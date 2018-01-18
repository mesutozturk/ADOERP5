using System;

namespace UrunYonetim.ViewModels
{
    public class SepetViewModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public short Quantity { get; set; } = 1;
        public decimal UnitPrice { get; set; } = 0;
        public float Discount { get; set; } = 0;
        public decimal Total
        {
            get => Quantity * UnitPrice * Convert.ToDecimal(1 - Discount);
        }
        public override string ToString() => $"{ProductName} {Quantity}x{UnitPrice:c2} = {Total:c2}";
    }
}
