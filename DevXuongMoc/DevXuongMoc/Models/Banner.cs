using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models
{
    public partial class Banner
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Hình ảnh")]
        public string? Image { get; set; }

        [DisplayName("Tiêu đề")]
        public string? Title { get; set; }

        [DisplayName("Phụ đề")]
        public string? SubTitle { get; set; }

        [DisplayName("Đường dẫn URL")]
        public string? Urls { get; set; }

        [DisplayName("Thứ tự")]
        public int Orders { get; set; }

        [DisplayName("Loại")]
        public string? Type { get; set; }

        [DisplayName("Ngày tạo")]
        public DateTime? CreatedDate { get; set; }

        [DisplayName("Ngày cập nhật")]
        public DateTime? UpdatedDate { get; set; }

        [DisplayName("Người tạo")]
        public string? AdminCreated { get; set; }

        [DisplayName("Người cập nhật")]
        public string? AdminUpdated { get; set; }

        [DisplayName("Ghi chú")]
        public string? Notes { get; set; }

        [DisplayName("Trạng thái")]
        public byte Status { get; set; }

        [DisplayName("Đã xóa")]
        public bool Isdelete { get; set; }
    }
}
