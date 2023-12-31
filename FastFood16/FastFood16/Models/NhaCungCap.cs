﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FastFood16.Models
{
    public partial class NhaCungCap
    {
        public NhaCungCap()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public int MaNcc { get; set; }
        public string TenNcc { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
