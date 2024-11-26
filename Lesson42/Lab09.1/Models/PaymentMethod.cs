namespace Lab09._1.Models
{
    public class PaymentMethod
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDelete { get; set; }
    }

}
