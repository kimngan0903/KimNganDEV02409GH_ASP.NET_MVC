using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models
{
    public partial class Customer
    {
        [DisplayName("Mã khách hàng")]
        public int CustomerId { get; set; }

        [DisplayName("Họ và tên")]
        public string? Name { get; set; }

        [DisplayName("Tên đăng nhập")]
        public string? Username { get; set; }

        [DisplayName("Mật khẩu")]
        public string? Password { get; set; }

        [DisplayName("Địa chỉ")]
        public string? Address { get; set; }

        [DisplayName("Email")]
        public string? Email { get; set; }

        [DisplayName("Số điện thoại")]
        public string? Phone { get; set; }

        [DisplayName("Ảnh đại diện")]
        public string? Avatar { get; set; }

        [DisplayName("Ngày tạo")]
        public DateTime? CreatedDate { get; set; }

        [DisplayName("Ngày cập nhật")]
        public DateTime? UpdatedDate { get; set; }

        [DisplayName("Người tạo")]
        public long? CreatedBy { get; set; }

        [DisplayName("Người cập nhật")]
        public long? UpdatedBy { get; set; }

        [DisplayName("Đã xóa")]
        public byte? Isdelete { get; set; }

        [DisplayName("Hoạt động")]
        public byte? Isactive { get; set; }
    }
}
