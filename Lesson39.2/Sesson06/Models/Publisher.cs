using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Sesson06.Models;

public partial class Publisher
{
    [DisplayName("Mã nhà xuất bản")]
    public int PublisherId { get; set; }

    [DisplayName("Tên nhà xuất bản")]
    [StringLength(100)]
    public string? PublisherName { get; set; }

    [DisplayName("Điện thoại")]
    [StringLength(10)]
    public string? Phone { get; set; }

    [DisplayName("Địa chỉ")]
    [StringLength(200)]
    public string? Address { get; set; }

    // Thuộc tính quan hệ
    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
