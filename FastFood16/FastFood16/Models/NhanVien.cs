using System;
using System.Collections.Generic;

#nullable disable

namespace FastFood16.Models
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            DonHangs = new HashSet<DonHang>();
            TaiKhoans = new HashSet<TaiKhoan>();
        }

        public int MaNv { get; set; }
        public string HoNv { get; set; }
        public string TenNv { get; set; }
        public DateTime? NgaySinh { get; set; }
        public DateTime? NgayVaoLam { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string GhiChu { get; set; }

        public virtual ICollection<DonHang> DonHangs { get; set; }
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
    }
}
