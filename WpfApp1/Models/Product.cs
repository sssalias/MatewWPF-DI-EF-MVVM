namespace WpfApp1.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public int ProductTypeID { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public string StorageConditions { get; set; }
        public string Packaging { get; set; }
        public DateTime ExpiryDate { get; set; }

        // Навигационная ссылка на тип товара
        public virtual ProductType Type { get; set; }
    }
}
