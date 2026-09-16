using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    public class NhanVienThoiVu : NhanVien
    {
        private double soGioLam;
        private double luongTheoGio;

        public double SoGioLam
        {
            get => soGioLam;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Số giờ làm không được âm.");
                soGioLam = value;
            }
        }

        public double LuongTheoGio
        {
            get => luongTheoGio;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Lương theo giờ phải lớn hơn 0.");
                luongTheoGio = value;
            }
        }

        public NhanVienThoiVu(string maNV, string hoTen, double soGioLam, double luongTheoGio)
            : base(maNV, hoTen, 1)
        {
            this.SoGioLam = soGioLam;
            this.LuongTheoGio = luongTheoGio;
        }

        public override double TinhLuong()
        {
            return SoGioLam * LuongTheoGio;
        }

        public override void HienThiThongTin()
        {
            Console.WriteLine($"[Thời Vụ   ] Mã NV: {MaNV,-6} | Tên: {HoTen,-18} | Giờ làm: {SoGioLam,3}h  | Thực lãnh: {TinhLuong(),13:N0} VNĐ");
        }
    }
}
