﻿using System;
using System.Collections.Generic;

namespace Lab09._1.Models;

public partial class Orderdetail
{
    public int Id { get; set; }

    public int? Idorders { get; set; }

    public int? Idproduct { get; set; }

    public decimal? Price { get; set; }

    public int? Qty { get; set; }

    public decimal? Total { get; set; }

    public int? ReturnQty { get; set; }
}
