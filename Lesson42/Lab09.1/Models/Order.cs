namespace Lab09._1.Models
{
    public class Order
    {
        public long ID { get; set; }
        public DateTime OrderDate { get; set; }
        public long CustomerId { get; set; }
        public decimal TotalMoney { get; set; }
        public string Notes { get; set; }
        public string NameReceiver { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool IsDelete { get; set; }
        public bool IsActive { get; set; }

        // Navigation property
        public Customer Customer { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }

}
