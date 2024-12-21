using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models
{
    public partial class ProductMaterial
    {
        [Key]
        [Display(Name = "Mã nguyên liệu")]
        public int Id { get; set; }

        [Display(Name = "Mã sản phẩm")]
        public int? Pid { get; set; }

        [Display(Name = "Mã vật liệu")]
        public int? Mid { get; set; }
    }
}
