using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models
{
    public partial class Material
    {
        [DisplayName("Mã vật liệu")]
        public int Id { get; set; }

        [DisplayName("Tiêu đề")]
        public string? Title { get; set; }

        [DisplayName("Biểu tượng")]
        public string? Icon { get; set; }

        [DisplayName("Tiêu đề Meta")]
        public string? MetaTitle { get; set; }

        [DisplayName("Từ khóa Meta")]
        public string? MetaKeyword { get; set; }

        [DisplayName("Mô tả Meta")]
        public string? MetaDescription { get; set; }

        [DisplayName("Slug")]
        public string? Slug { get; set; }

        [DisplayName("Thứ tự")]
        public int? Orders { get; set; }

        [DisplayName("Mã cha")]
        public int? Parentid { get; set; }

        [DisplayName("Ngày tạo")]
        public DateTime? CreatedDate { get; set; }

        [DisplayName("Ngày cập nhật")]
        public DateTime? UpdatedDate { get; set; }

        [DisplayName("Quản trị viên tạo")]
        public string? AdminCreated { get; set; }

        [DisplayName("Quản trị viên cập nhật")]
        public string? AdminUpdated { get; set; }

        [DisplayName("Ghi chú")]
        public string? Notes { get; set; }

        [DisplayName("Trạng thái")]
        public byte? Status { get; set; }

        [DisplayName("Đã xóa")]
        public bool? Isdelete { get; set; }
    }
}
