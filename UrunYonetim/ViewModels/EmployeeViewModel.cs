namespace UrunYonetim.ViewModels
{
    public class EmployeeViewModel
    {
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public string Title { get; set; }
        public override string ToString() => $"{FullName} - {Title}";
    }
}
