using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Sesson06.Models;

public partial class Book
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
    public virtual Category? Category { get; set; }


    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual Publisher? Publisher { get; set; }
}
