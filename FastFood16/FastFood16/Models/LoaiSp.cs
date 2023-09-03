﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FastFood16.Models
{
    public partial class LoaiSp
    {
        public LoaiSp()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public int MaLoai { get; set; }
        public string TenLoai { get; set; }
        public string Discription { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
