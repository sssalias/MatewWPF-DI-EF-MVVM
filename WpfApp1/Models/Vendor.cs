namespace WpfApp1.Models
{
    internal class Vendor
    {
        public int VendorID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        // Списки поставляемых товаров
        public int[] SuppliedProductIDs { get; set; }

        // Навигационный доступ к списку продуктов
        public virtual ICollection<Product> SuppliedProducts { get; set; }
    }
}
