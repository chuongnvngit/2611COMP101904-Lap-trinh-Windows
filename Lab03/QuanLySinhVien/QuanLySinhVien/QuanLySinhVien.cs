using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    public class QuanLySinhVien
    {
        private readonly List<SinhVien> danhSach = new List<SinhVien>();

        public bool KiemTraTonTai(string maSV)
        {
            return danhSach.Any(sv => sv.MaSinhVien.Equals(maSV, StringComparison.OrdinalIgnoreCase));
        }

        public bool Them(SinhVien sv)
        {
            if (KiemTraTonTai(sv.MaSinhVien)) return false;
            danhSach.Add(sv);
            return true;
        }

        public List<SinhVien> LayDanhSach()
        {
            return danhSach.ToList();
        }

        public SinhVien TimTheoMa(string maSV)
        {
            return danhSach.FirstOrDefault(sv => sv.MaSinhVien.Equals(maSV, StringComparison.OrdinalIgnoreCase));
        }

        public List<SinhVien> TimTheoTen(string tuKhoa)
        {
            return danhSach.Where(sv => sv.HoTen.IndexOf(tuKhoa, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

        public bool Sua(string maSV, double diemMoi)
        {
            var sv = TimTheoMa(maSV);
            if (sv == null) return false;

            sv.DiemTrungBinh = diemMoi;
            return true;
        }

        public bool Xoa(string maSV)
        {
            var sv = TimTheoMa(maSV);
            if (sv == null) return false;

            return danhSach.Remove(sv);
        }

        public List<SinhVien> SapXepTheoDiemGiamDan()
        {
            return danhSach.OrderByDescending(sv => sv.DiemTrungBinh).ToList();
        }

        public List<SinhVien> LocSinhVienDat()
        {
            return danhSach.Where(sv => sv.DiemTrungBinh >= 5.0).ToList();
        }
    }
}
