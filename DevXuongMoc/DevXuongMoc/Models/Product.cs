using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models
{
    public partial class Product
    {
        [DisplayName("Mã sản phẩm")]
        public int Id { get; set; }

        [DisplayName("Danh mục")]
        public int? Cid { get; set; }

        [DisplayName("Mã sản phẩm")]
        public string? Code { get; set; }

        [DisplayName("Tên sản phẩm")]
        public string? Title { get; set; }

        [DisplayName("Mô tả")]
        public string? Description { get; set; }

        [DisplayName("Nội dung")]
        public string? Content { get; set; }

        [DisplayName("Ảnh sản phẩm")]
        public string? Image { get; set; }

        [DisplayName("Meta Title")]
        public string? MetaTitle { get; set; }

        [DisplayName("Meta Keyword")]
        public string? MetaKeyword { get; set; }

        [DisplayName("Meta Description")]
        public string? MetaDescription { get; set; }

        [DisplayName("Slug")]
        public string? Slug { get; set; }

        [DisplayName("Giá cũ")]
        public decimal? PriceOld { get; set; }

        [DisplayName("Giá mới")]
        public decimal? PriceNew { get; set; }

        [DisplayName("Kích cỡ")]
        public string? Size { get; set; }

        [DisplayName("Số lượt xem")]
        public int? Views { get; set; }

        [DisplayName("Số lượt thích")]
        public int? Likes { get; set; }

        [DisplayName("Đánh giá")]
        public double? Star { get; set; }

        [DisplayName("Trang chủ")]
        public byte? Home { get; set; }

        [DisplayName("Hot")]
        public byte? Hot { get; set; }

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
