using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager
{
    public class Product
    {
        public string MaSP { get; set; } = string.Empty;
        public string TenSP { get; set; } = string.Empty;
        public string LoaiSP { get; set; } = string.Empty;
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayNhap { get; set; }
        public bool ConKinhDoanh { get; set; }
        public string DuongDanAnh { get; set; } = string.Empty;

        // Thuộc tính tính toán (Read-only property)
        public decimal ThanhTien
        {
            get { return DonGia * SoLuong; }
        }
    }
}
