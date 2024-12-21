using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models
{
    public partial class AdminLog
    {
        [DisplayName("ID Nhật ký")]
        public int LogId { get; set; }

        [DisplayName("Trạng thái")]
        public int? Status { get; set; }

        [DisplayName("ID Phiên")]
        public string? SessionId { get; set; }

        [DisplayName("Mã ứng dụng")]
        public string? AppCode { get; set; }

        [DisplayName("ID Luồng")]
        public string? ThreadId { get; set; }

        [DisplayName("Thời gian bắt đầu")]
        [DataType(DataType.DateTime)]
        public DateTime? StartTime { get; set; }

        [DisplayName("Thời gian kết thúc")]
        [DataType(DataType.DateTime)]
        public DateTime? EndTime { get; set; }

        [DisplayName("ID Quản trị viên")]
        public int? AdminUserId { get; set; }

        [DisplayName("Tài khoản đăng nhập")]
        public string? UserLogin { get; set; }

        [DisplayName("Tên người dùng")]
        public string? UserName { get; set; }

        [DisplayName("Địa chỉ IP")]
        public string? IpAddress { get; set; }

        [DisplayName("Mã hành động")]
        public string? ActionCode { get; set; }

        [DisplayName("Tên hành động")]
        public string? ActionName { get; set; }

        [DisplayName("Mã menu")]
        public string? MenuCode { get; set; }

        [DisplayName("Tên menu")]
        public string? MenuName { get; set; }

        [DisplayName("ID Hành động web")]
        public int? WebpagesActionId { get; set; }

        [DisplayName("Loại hành động")]
        public int? ActionType { get; set; }

        [DisplayName("ID Đối tượng")]
        public int? ObjectId { get; set; }

        [DisplayName("Nội dung")]
        public string? Content { get; set; }

        [DisplayName("Mô tả")]
        public string? Description { get; set; }

        [DisplayName("Cấp độ nhật ký")]
        public int? LogLevel { get; set; }

        [DisplayName("Mã lỗi")]
        public string? ErrorCode { get; set; }
    }
}
