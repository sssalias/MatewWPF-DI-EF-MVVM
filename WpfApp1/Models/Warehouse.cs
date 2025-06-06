namespace WpfApp1.Models
{
    public class Warehouse
    {
        public int ID { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippingDate { get; set; }
        public int ProductID { get; set; }
        public int VendorID { get; set; }
        public int CustomerID { get; set; }
        public string DeliveryMethod { get; set; }
        public double Volume { get; set; }
        public decimal Price { get; set; }
        public int StaffID { get; set; }

        // Навигационные ссылки
        public virtual Product Product { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Staff Employee { get; set; }
    }
}
