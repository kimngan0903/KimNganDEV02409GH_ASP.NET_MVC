using System;
using System.ComponentModel.DataAnnotations;

namespace Lab04.Models
{
    public class People
    {
        [Key]
        public int Id { get; set; }

        [
            Display(Name = "Họ và tên"),
            Required(ErrorMessage = "Họ tên không được để trống"),
            MinLength(6, ErrorMessage = "Họ tên ít nhất là 6 ký tự"),
            MaxLength(20, ErrorMessage = "Họ tên tối đa 20 ký tự")
        ]
        public string Name { get; set; }

        [Display(Name = "Địa chỉ email")]
        [Required(ErrorMessage = "Địa chỉ email không được để trống")]
        [EmailAddress(ErrorMessage = "Địa chỉ Email khôg đúng định dạng")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Số điện thoại")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0- 9]{4})$", ErrorMessage = "Số điện thoại không đúng định dạng")]
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        public string Phone { get; set; }

        [Display(Name = "Địa chỉ nơi ở")]
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        [StringLength(35, ErrorMessage = "Địa chỉ không vượt quá 35 ký tự")]

        public string Address { get; set; }

        [Display(Name = "Ảnh đại diện")]
        public string Avatar { get; set; }

        [Display(Name = "Ngày sinh nhật")]
        [Required(ErrorMessage = "Ngày sinh nhật không được để trống")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Display(Name = "Giới thiệu bản thân")]
        public string Bio { get; set; }

        [Display(Name = "Giới tính")]
        public byte Gender { get; set; }
    }
}
