﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebBanSua.Models
{
    public partial class TrangThaiDh
    {
        public int MaTtdh { get; set; }
        public int MaDh { get; set; }
        public string TrangThai { get; set; }
        public string Mota { get; set; }

        public virtual DonHang MaDhNavigation { get; set; }
    }
}
