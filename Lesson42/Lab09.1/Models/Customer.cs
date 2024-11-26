namespace Lab09._1.Models
{
    public class Customer
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public byte IsDelete { get; set; }
        public byte IsActive { get; set; }

        // Navigation property
        public ICollection<Order> Orders { get; set; }
    }

}
