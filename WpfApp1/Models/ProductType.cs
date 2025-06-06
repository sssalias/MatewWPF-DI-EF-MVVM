namespace WpfApp1.Models
{
    internal class ProductType
    {
        public int ProductTypeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Features { get; set; }

        // Навигационный доступ к продуктам данного типа
        public virtual ICollection<Product> Products { get; set; }
    }
}
