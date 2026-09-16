using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    public class NhanVienKinhDoanh  : NhanVien
    {
        private double doanhSo;

        public double DoanhSo
        {
            get => doanhSo;
            set
            {
                if (value < 0 || value > 31)
                    throw new ArgumentException("Doanh số không được âm.");
                doanhSo = value;
            }
        }

        public NhanVienKinhDoanh(string maNV, string hoTen, double luongCoBan, double doanhSo)
            : base(maNV, hoTen, luongCoBan)
        {
            this.doanhSo = doanhSo;
        }

        public override double TinhLuong()
        {
            return LuongCoBan + 0.05 * DoanhSo;
        }

        public override void HienThiThongTin()
        {
            Console.WriteLine($"[Kinh Doanh] Mã NV: {MaNV,-6} | Tên: {HoTen,-18} | Doanh số: {DoanhSo,10:N0} | Thực lãnh: {TinhLuong(),13:N0} VNĐ");
        }
    }
}
