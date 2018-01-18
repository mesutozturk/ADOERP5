namespace ADO1
{
    public class ProductViewModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public bool Discontinued { get; set; }
    }
}
