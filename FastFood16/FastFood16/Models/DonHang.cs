using System;
using System.Collections.Generic;

#nullable disable

namespace FastFood16.Models
{
    public partial class DonHang
    {
        public DonHang()
        {
            HoaDonDatHangs = new HashSet<HoaDonDatHang>();
        }

        public int MaDh { get; set; }
        public int? MaKh { get; set; }
        public int? MaNv { get; set; }
        public string Omessage { get; set; }
        public DateTime? NgayDat { get; set; }
        public DateTime? NgayGiao { get; set; }
        public string DiaChiNhan { get; set; }
        public string TrangThai { get; set; }
        public decimal? TongTien { get; set; }

        public virtual KhachHang MaKhNavigation { get; set; }
        public virtual NhanVien MaNvNavigation { get; set; }
        public virtual ICollection<HoaDonDatHang> HoaDonDatHangs { get; set; }
    }
}
