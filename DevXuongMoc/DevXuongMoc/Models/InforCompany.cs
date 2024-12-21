using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models
{
    public partial class InforCompany
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Tên công ty")]
        [Required(ErrorMessage = "Tên công ty là bắt buộc.")]
        public string? Name { get; set; }

        [Display(Name = "Logo")]
        public string? Logo { get; set; }

        [Display(Name = "Số điện thoại")]
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ.")]
        public string? Phone { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ.")]
        public string? Email { get; set; }

        [Display(Name = "Địa chỉ")]
        public string? Address { get; set; }

        [Display(Name = "Youtube")]
        public string? Youtube { get; set; }

        [Display(Name = "Instagram")]
        public string? Instagram { get; set; }

        [Display(Name = "Facebook")]
        public string? Facebook { get; set; }

        [Display(Name = "Ngày tạo")]
        public DateOnly? CreatedDate { get; set; }

        [Display(Name = "Ngày cập nhật")]
        public DateOnly? UpdateDate { get; set; }

        [Display(Name = "Người tạo")]
        public string? AdminCreated { get; set; }

        [Display(Name = "Người cập nhật")]
        public string? AdminUpdated { get; set; }

        [Display(Name = "Meta Tiêu đề")]
        public string? MetaTitle { get; set; }

        [Display(Name = "Meta Từ khóa")]
        public string? MetaKeyword { get; set; }

        [Display(Name = "Meta Mô tả")]
        public string? MetaDescription { get; set; }
    }
}
