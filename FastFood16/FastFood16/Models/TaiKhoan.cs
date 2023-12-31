﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FastFood16.Models
{
    public partial class TaiKhoan
    {
        public int MaTk { get; set; }
        public int? MaKh { get; set; }
        public int? MaNv { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }

        public virtual KhachHang MaKhNavigation { get; set; }
        public virtual NhanVien MaNvNavigation { get; set; }
    }
}
