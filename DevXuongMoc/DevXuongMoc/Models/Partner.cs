using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models
{
    public partial class Partner
    {
        [DisplayName("Mã đối tác")]
        public int Id { get; set; }

        [DisplayName("Tên đối tác")]
        public string? Title { get; set; }

        [DisplayName("Logo")]
        public string? Logo { get; set; }

        [DisplayName("URL")]
        public string? Url { get; set; }

        [DisplayName("Thứ tự")]
        public byte? Orders { get; set; }

        [DisplayName("Ngày tạo")]
        public DateTime? CreatedDate { get; set; }

        [DisplayName("Ngày cập nhật")]
        public DateTime? UpdatedDate { get; set; }

        [DisplayName("Quản trị viên tạo")]
        public string? AdminCreated { get; set; }

        [DisplayName("Quản trị viên cập nhật")]
        public string? AdminUpdated { get; set; }

        [DisplayName("Nội dung")]
        public string? Content { get; set; }

        [DisplayName("Trạng thái")]
        public byte? Status { get; set; }

        [DisplayName("Đã xóa")]
        public bool? Isdelete { get; set; }
    }
}
