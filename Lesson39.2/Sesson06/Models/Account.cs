using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Sesson06.Models;

public partial class Account
{
    [DisplayName("Mã tài khoản")]
    [StringLength(10)]
    public string AccountId { get; set; } = null!;

    [DisplayName("Tên người dùng")]
    [Required(ErrorMessage = "Tên người dùng không được bỏ trống")]
    [StringLength(100)]
    public string Username { get; set; } = null!;

    [DisplayName("Mật khẩu")]
    [Required(ErrorMessage = "Mật khẩu không được bỏ trống")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }

    [DisplayName("Tên đầy đủ")]
    public string? FullName { get; set; }

    [DisplayName("Ảnh người dùng")]
    public string? Picture { get; set; }

    [DisplayName("Email")]
    [Required(ErrorMessage = "Email không được bỏ trống")]
    public string? Email { get; set; }

    [DisplayName("Địa chỉ")]
    public string? Address { get; set; }

    [DisplayName("Số điện thoại")]
    public string? Phone { get; set; }

    [DisplayName("Phân quyền")]
    public bool? IsAdmin { get; set; }

    [DisplayName("Hành động")]
    public bool? Active { get; set; }

    public virtual ICollection<OrderBook> OrderBooks { get; set; } = new List<OrderBook>();
}
