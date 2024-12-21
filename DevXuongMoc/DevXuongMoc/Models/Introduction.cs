using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models
{
    public partial class Introduction
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Tiêu đề")]
        public string Title { get; set; } = null!;

        [Display(Name = "Hình ảnh")]
        public string Image { get; set; } = null!;

        [Display(Name = "Số thứ tự")]
        public int? Orders { get; set; }

        [Display(Name = "Mô tả")]
        public string? Description { get; set; }

        [Display(Name = "Hiển thị trang chủ")]
        public byte? Home { get; set; }

        [Display(Name = "Loại")]
        public byte? Type { get; set; }

        [Display(Name = "ID cha")]
        public int? Parentid { get; set; }

        [Display(Name = "Meta Tiêu đề")]
        public string? MetaTitle { get; set; }

        [Display(Name = "Meta Từ khóa")]
        public string? MetaKeyword { get; set; }

        [Display(Name = "Meta Mô tả")]
        public string? MetaDescription { get; set; }

        [Display(Name = "Slug")]
        public string? Slug { get; set; }

        [Display(Name = "Ngày tạo")]
        public DateTime? CreatedDate { get; set; }

        [Display(Name = "Ngày cập nhật")]
        public DateTime? UpdatedDate { get; set; }

        [Display(Name = "Người tạo")]
        public string? AdminCreated { get; set; }

        [Display(Name = "Người cập nhật")]
        public string? AdminUpdated { get; set; }

        [Display(Name = "Nội dung")]
        public string? Content { get; set; }

        [Display(Name = "Trạng thái")]
        public byte Status { get; set; }

        [Display(Name = "Đã xóa")]
        public bool Isdelete { get; set; }
    }
}
