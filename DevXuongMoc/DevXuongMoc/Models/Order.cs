using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models
{
    public partial class Order
    {
        [DisplayName("Mã đơn hàng")]
        public int Id { get; set; }

        [DisplayName("Mã đơn hàng duy nhất")]
        public string? Idorders { get; set; }

        [DisplayName("Ngày đặt hàng")]
        public DateTime? OrdersDate { get; set; }

        [DisplayName("Mã khách hàng")]
        public long? Idcustomer { get; set; }

        [DisplayName("Phương thức thanh toán")]
        public long? Idpayment { get; set; }

        [DisplayName("Tổng tiền")]
        public decimal? TotalMoney { get; set; }

        [DisplayName("Ghi chú")]
        public string? Notes { get; set; }

        [DisplayName("Tên người nhận")]
        public string? NameReciver { get; set; }

        [DisplayName("Địa chỉ người nhận")]
        public string? Address { get; set; }

        [DisplayName("Email người nhận")]
        public string? Email { get; set; }

        [DisplayName("Số điện thoại người nhận")]
        public string? Phone { get; set; }

        [DisplayName("Đã xóa")]
        public byte? Isdelete { get; set; }

        [DisplayName("Hoạt động")]
        public byte? Isactive { get; set; }
    }
}
