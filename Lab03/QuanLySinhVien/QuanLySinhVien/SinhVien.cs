using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    public class SinhVien : Nguoi
    {
        private double diemTrungBinh;

        public string MaSinhVien { get; set; }
        public string MaLop { get; set; }

        public double DiemTrungBinh
        {
            get => diemTrungBinh;
            set
            {
                if (value < 0 || value > 10)
                    throw new ArgumentException("Điểm trung bình phải nằm trong khoảng từ 0 đến 10.");
                diemTrungBinh = value;
            }
        }

        public SinhVien() { }

        public SinhVien(string maSinhVien, string hoTen, DateTime ngaySinh, string maLop, double diemTB)
            : base(hoTen, ngaySinh)
        {
            MaSinhVien = maSinhVien;
            MaLop = maLop;
            DiemTrungBinh = diemTB;
        }

        public string XepLoai()
        {
            if (DiemTrungBinh >= 8.5) return "Xuất sắc";
            if (DiemTrungBinh >= 8.0) return "Giỏi";
            if (DiemTrungBinh >= 6.5) return "Khá";
            if (DiemTrungBinh >= 5.0) return "Trung bình";
            return "Yếu";
        }

        public override string LayThongTin()
        {
            return $"Mã SV: {MaSinhVien,-8} | {base.LayThongTin()} | Lớp: {MaLop,-8} | ĐTB: {DiemTrungBinh,4:F1} | Xếp loại: {XepLoai()}";
        }
    }
}
