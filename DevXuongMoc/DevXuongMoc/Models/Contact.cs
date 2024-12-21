using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models
{
    public partial class Contact
    {
        [DisplayName("Mã liên hệ")]
        public int Id { get; set; }

        [DisplayName("Tiêu đề")]
        public string? Title { get; set; }

        [DisplayName("Email")]
        public string? Email { get; set; }

        [DisplayName("Số điện thoại")]
        public string? Phone { get; set; }

        [DisplayName("Địa chỉ")]
        public string? Address { get; set; }

        [DisplayName("Nội dung")]
        public string? Content { get; set; }

        [DisplayName("Ngày tạo")]
        public DateTime? CreatedDate { get; set; }

        [DisplayName("Ngày cập nhật")]
        public DateTime? UpdatedDate { get; set; }

        [DisplayName("Người tạo")]
        public string? AdminCreated { get; set; }

        [DisplayName("Người cập nhật")]
        public string? AdminUpdated { get; set; }

        [DisplayName("Trạng thái")]
        public byte? Status { get; set; }

        [DisplayName("Đã xóa")]
        public bool? Isdelete { get; set; }
    }
}
