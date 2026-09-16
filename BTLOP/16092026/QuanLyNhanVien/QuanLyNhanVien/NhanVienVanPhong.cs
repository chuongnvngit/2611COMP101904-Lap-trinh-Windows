using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    public class NhanVienVanPhong : NhanVien
    {
        private int soNgayLamViec;

        public int SoNgayLamViec
        {
            get => soNgayLamViec;
            set
            {
                if (value < 0 || value > 31)
                    throw new ArgumentException("Số ngày làm việc phải từ 0 đến 31 ngày.");
                soNgayLamViec = value;
            }
        }

        public NhanVienVanPhong(string maNV, string hoTen, double luongCoBan, int soNgayLamViec) : base(maNV, hoTen, luongCoBan)
        {
            this.SoNgayLamViec = soNgayLamViec;
        }

        public override double TinhLuong()
        {
            return LuongCoBan + SoNgayLamViec * 200000;
        }

        public override void HienThiThongTin()
        {
            Console.WriteLine($"[Văn Phòng ] Mã NV: {MaNV,-6} | Tên: {HoTen,-18} | Ngày làm: {SoNgayLamViec,2} | Thực lãnh: {TinhLuong(),13:N0} VNĐ");
        }
    }
}
