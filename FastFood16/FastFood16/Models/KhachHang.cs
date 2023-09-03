using System;
using System.Collections.Generic;

#nullable disable

namespace FastFood16.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            DonHangs = new HashSet<DonHang>();
            TaiKhoans = new HashSet<TaiKhoan>();
        }

        public int MaKh { get; set; }
        public string HoKh { get; set; }
        public string TenKh { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }

        public virtual ICollection<DonHang> DonHangs { get; set; }
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
    }
}
