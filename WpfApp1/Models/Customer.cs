namespace WpfApp1.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        // Потребляемые товары
        public int[] ConsumedProductIDs { get; set; }

        // Навигационный доступ к потребляемым товарам
        public virtual ICollection<Product> ConsumedProducts { get; set; }
    }
}
