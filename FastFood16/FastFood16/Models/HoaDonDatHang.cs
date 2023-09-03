using System;
using System.Collections.Generic;

#nullable disable

namespace FastFood16.Models
{
    public partial class HoaDonDatHang
    {
        public int MaDh { get; set; }
        public int MaSp { get; set; }
        public int SoLuong { get; set; }
        public decimal ThanhTien { get; set; }
        public float Discount { get; set; }

        public virtual DonHang MaDhNavigation { get; set; }
        public virtual SanPham MaSpNavigation { get; set; }
    }
}
