using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models
{
    public partial class PaymentMethod
    {
        [DisplayName("Mã phương thức thanh toán")]
        public int Id { get; set; }

        [DisplayName("Tên phương thức thanh toán")]
        public string? Name { get; set; }

        [DisplayName("Ghi chú")]
        public string? Notes { get; set; }

        [DisplayName("Ngày tạo")]
        public DateTime? CreatedDate { get; set; }

        [DisplayName("Ngày cập nhật")]
        public DateTime? UpdatedDate { get; set; }

        [DisplayName("Đã xóa")]
        public byte? Isdelete { get; set; }

        [DisplayName("Trạng thái hoạt động")]
        public byte? Isactive { get; set; }
    }
}
