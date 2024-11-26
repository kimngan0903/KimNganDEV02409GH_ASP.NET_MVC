namespace Lab09._1.Models
{
    public class OrderDetail
    {
        public long ID { get; set; }
        public long OrderId { get; set; }
        public long ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
        public int ReturnQuantity { get; set; }

        // Navigation property
        public Order Order { get; set; }
    }

}
