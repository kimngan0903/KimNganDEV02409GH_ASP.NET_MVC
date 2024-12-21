using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models
{
    public partial class Orderdetail
    {
        [DisplayName("Mã chi tiết đơn hàng")]
        public int Id { get; set; }

        [DisplayName("Mã đơn hàng")]
        public int? Idorders { get; set; }

        [DisplayName("Mã sản phẩm")]
        public int? Idproduct { get; set; }

        [DisplayName("Giá sản phẩm")]
        public decimal? Price { get; set; }

        [DisplayName("Số lượng")]
        public int? Qty { get; set; }

        [DisplayName("Tổng tiền")]
        public decimal? Total { get; set; }

        [DisplayName("Số lượng trả lại")]
        public int? ReturnQty { get; set; }
    }
}
