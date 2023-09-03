using System;
using System.Collections.Generic;

#nullable disable

namespace FastFood16.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            HoaDonDatHangs = new HashSet<HoaDonDatHang>();
        }

        public int MaSp { get; set; }
        public int? MaLoai { get; set; }
        public int? MaNcc { get; set; }
        public string TenSp { get; set; }
        public decimal? DonGia { get; set; }
        public string MoTa { get; set; }

        public virtual LoaiSp MaLoaiNavigation { get; set; }
        public virtual NhaCungCap MaNccNavigation { get; set; }
        public virtual ICollection<HoaDonDatHang> HoaDonDatHangs { get; set; }
    }
}
