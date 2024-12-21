using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models
{
    public partial class Category
    {
        [DisplayName("Mã danh mục")]
        public int Id { get; set; }

        [DisplayName("Tiêu đề")]
        public string? Title { get; set; }

        [DisplayName("Biểu tượng")]
        public string? Icon { get; set; }

        [DisplayName("Meta Title")]
        public string? MateTitle { get; set; }

        [DisplayName("Meta Keywords")]
        public string? MetaKeyword { get; set; }

        [DisplayName("Meta Description")]
        public string? MetaDescription { get; set; }

        [DisplayName("Slug")]
  
        public string? Slug { get; set; }

        [DisplayName("Thứ tự")]
        public int? Orders { get; set; }

        [DisplayName("ID danh mục cha")]
        public int? Parentid { get; set; }

        [DisplayName("Ngày tạo")]
        [DataType(DataType.DateTime)]
        public DateTime? CreatedDate { get; set; }

        [DisplayName("Ngày cập nhật")]
        [DataType(DataType.DateTime)]
        public DateTime? UpdatedDate { get; set; }

        [DisplayName("Người tạo")]
        public string? AdminCreated { get; set; }

        [DisplayName("Người cập nhật")]
        public string? AdminUpdated { get; set; }

        [DisplayName("Ghi chú")]
        public string? Notes { get; set; }

        [DisplayName("Trạng thái")]
        public byte? Status { get; set; }

        [DisplayName("Đã xóa")]
        public bool? Isdelete { get; set; }
    }
}
