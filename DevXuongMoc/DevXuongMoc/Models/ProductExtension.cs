using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models
{
    public partial class ProductExtension
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Mã sản phâme")]
        public int? Pid { get; set; }

        [Display(Name = "Mã mở rộng")]
        public int? Eid { get; set; }

        [Display(Name = "Nội dung mở rộng")]
        public string? Content { get; set; }
    }
}
