using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Sesson06.Models;

public partial class Category
{
    [DisplayName("Mã loại")]
    public int CategoryId { get; set; }

    [DisplayName("Tên loại")]
    [StringLength(100)]
    public string? CategoryName { get; set; }

    // Thuộc tính quan hệ
    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
