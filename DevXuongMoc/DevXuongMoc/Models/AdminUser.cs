using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models
{
    public partial class AdminUser
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Tài khoản")]
        public string? Account { get; set; }

        [DisplayName("Mật khẩu")]
        public string? Password { get; set; }

        [DisplayName("Mã nhân sự")]
        public int? MaNhanSu { get; set; }

        [DisplayName("Họ và tên")]
        public string? Name { get; set; }

        [DisplayName("Số điện thoại")]
        public string? Phone { get; set; }

        [DisplayName("Email")]
        public string? Email { get; set; }

        [DisplayName("Ảnh đại diện")]
        public string? Avatar { get; set; }

        [DisplayName("ID Phòng ban")]
        public int? IdPhongBan { get; set; }

        [DisplayName("Ngày tạo")]
        public DateTime? NgayTao { get; set; }

        [DisplayName("Người tạo")]
        public string? NguoiTao { get; set; }

        [DisplayName("Ngày cập nhật")]
        public DateTime? NgayCapNhat { get; set; }

        [DisplayName("Người cập nhật")]
        public string? NguoiCapNhat { get; set; }

        [DisplayName("Token phiên làm việc")]
        public string? SessionToken { get; set; }

        [DisplayName("Salt")]
        public string? Salt { get; set; }

        [DisplayName("Là quản trị viên")]
        public bool? IsAdmin { get; set; }

        [DisplayName("Trạng thái")]
        public int? TrangThai { get; set; }

        [DisplayName("Đã xóa")]
        public bool? IsDelete { get; set; }
    }
}
