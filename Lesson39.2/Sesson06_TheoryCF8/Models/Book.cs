using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Sesson06_TheoryCF8.Models
{
    [Table("Book")]
    public class Book
    {
        [DisplayName("Mã sách")]
        [StringLength(10)]
        public string BookId { get; set; } = null!;

        [DisplayName("Tên sách")]
        [StringLength(200)]
        public string Title { get; set; } = null!;

        [DisplayName("Tác giả")]
        [StringLength(100)]
        public string? Author { get; set; }

        [DisplayName("Năm xuất bản")]
        public int? Release { get; set; }

        [DisplayName("Giá")]
        public double? Price { get; set; }

        [DisplayName("Mô tả")]
        public string? Description { get; set; }

        [DisplayName("Hình ảnh")]
        public string? Picture { get; set; }

        [DisplayName("Mã nhà sản xuất")]
        public int? PublisherId { get; set; }

        [DisplayName("Mã loại")]
        public int? CategoryId { get; set; }

        // Tạo các quan hệ giữa các thực thể
        public Category Category { get; set; }
        public Publisher Publisher {  get; set; }
    }
}
