using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    internal class Program
    {
        private static readonly QuanLySinhVien ql = new QuanLySinhVien();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            // Dữ liệu mẫu ban đầu để kiểm thử nhanh
            ql.Them(new SinhVien("SV001", "Nguyễn Văn A", new DateTime(2004, 5, 12), "CNTT01", 8.2));
            ql.Them(new SinhVien("SV002", "Trần Thị B", new DateTime(2004, 11, 23), "CNTT01", 4.5));
            ql.Them(new SinhVien("SV003", "Lê Văn C", new DateTime(2003, 2, 19), "CNTT02", 9.0));
            int chon = -1;
            do
            {
                HienThiMenu();
                Console.Write("Chon chuc nang: ");
                string input = Console.ReadLine();

                // Kiểm tra nếu không phải số hoặc nằm ngoài khoảng 0 - 8
                if (!int.TryParse(input, out chon) || chon < 0 || chon > 8)
                {
                    BaoLoi("Lựa chọn không hợp lệ! Vui lòng nhập số nguyên từ 0 đến 8.");
                    chon = -1;  // Đặt lại giá trị khác 0 để tránh vô tình trùng lệnh thoát
                    continue;   // Nhảy ngay về đầu vòng lặp hiển thị lại menu
                }

                switch (chon)
                {
                    case 1:
                        ThemSinhVien();
                        break;
                    case 2:
                        InDanhSach(ql.LayDanhSach(), "DANH SÁCH TẤT CẢ SINH VIÊN");
                        break;
                    case 3:
                        TimSinhVienTheoMa();
                        break;
                    case 4:
                        TimSinhVienTheoTen();
                        break;
                    case 5:
                        SuaDiemSinhVien();
                        break;
                    case 6:
                        XoaSinhVien();
                        break;
                    case 7:
                        InDanhSach(ql.SapXepTheoDiemGiamDan(), "DANH SÁCH SẮP XẾP ĐIỂM GIẢM DẦN (LINQ)");
                        break;
                    case 8:
                        InDanhSach(ql.LocSinhVienDat(), "DANH SÁCH SINH VIÊN ĐẠT (ĐTB >= 5.0 - LINQ)");
                        break;
                    case 0:
                        Console.WriteLine("Đã thoát chương trình.");
                        break;
                }

            } while (chon != 0); // Chỉ dừng khi người dùng gõ số 0 hợp lệ
        }

        static void HienThiMenu()
        {
            Console.WriteLine("\n===== QUAN LY SINH VIEN =====");
            Console.WriteLine("1. Them sinh vien");
            Console.WriteLine("2. Xuat danh sach");
            Console.WriteLine("3. Tim sinh vien theo ma");
            Console.WriteLine("4. Tim sinh vien theo ten");
            Console.WriteLine("5. Sua diem trung binh");
            Console.WriteLine("6. Xoa sinh vien");
            Console.WriteLine("7. Sap xep theo diem giam dan");
            Console.WriteLine("8. Loc sinh vien dat");
            Console.WriteLine("0. Thoat");
        }

        static void InDanhSach(List<SinhVien> ds, string tieuDe)
        {
            Console.WriteLine($"\n--- {tieuDe} ---");
            if (ds == null || ds.Count == 0)
            {
                Console.WriteLine("Danh sách trống.");
                return;
            }
            foreach (var sv in ds)
            {
                Console.WriteLine(sv.LayThongTin());
            }
        }

        static void ThemSinhVien()
        {
            Console.WriteLine("\n--- THÊM SINH VIÊN MỚI ---");
            string maSV;
            while (true)
            {
                Console.Write("Nhập mã sinh viên: ");
                maSV = Console.ReadLine()?.Trim() ?? "";
                if (string.IsNullOrEmpty(maSV))
                {
                    BaoLoi("Mã sinh viên không được để trống.");
                    continue;
                }
                if (ql.KiemTraTonTai(maSV))
                {
                    BaoLoi($"Mã '{maSV}' đã tồn tại trong hệ thống. Vui lòng nhập mã khác!");
                    return;
                }
                break;
            }

            Console.Write("Nhập họ tên: ");
            string hoTen = Console.ReadLine()?.Trim() ?? "";

            DateTime ngaySinh;
            while (true)
            {
                Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
                string strNgay = Console.ReadLine();
                if (DateTime.TryParseExact(strNgay, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaySinh))
                {
                    break;
                }
                BaoLoi("Định dạng ngày không hợp lệ! Vui lòng nhập đúng định dạng ngày/tháng/năm (vd: 20/11/2004).");
            }

            Console.Write("Nhập mã lớp: ");
            string maLop = Console.ReadLine()?.Trim() ?? "";

            double diemTB;
            while (true)
            {
                Console.Write("Nhập điểm trung bình (0 - 10): ");
                if (double.TryParse(Console.ReadLine(), out diemTB) && diemTB >= 0 && diemTB <= 10)
                {
                    break;
                }
                BaoLoi("Điểm không hợp lệ! Điểm phải là số thực từ 0 đến 10.");
            }

            SinhVien svMoi = new SinhVien(maSV, hoTen, ngaySinh, maLop, diemTB);
            if (ql.Them(svMoi))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Thêm sinh viên thành công!");
                Console.ResetColor();
            }
        }

        static void TimSinhVienTheoMa()
        {
            Console.Write("\nNhập mã sinh viên cần tìm: ");
            string ma = Console.ReadLine()?.Trim() ?? "";
            var sv = ql.TimTheoMa(ma);
            if (sv != null)
            {
                Console.WriteLine("Kết quả tìm kiếm:");
                Console.WriteLine(sv.LayThongTin());
            }
            else
            {
                BaoLoi($"Không tìm thấy sinh viên có mã '{ma}'.");
            }
        }

        static void TimSinhVienTheoTen()
        {
            Console.Write("\nNhập từ khóa họ tên cần tìm: ");
            string tuKhoa = Console.ReadLine()?.Trim() ?? "";
            var ketQua = ql.TimTheoTen(tuKhoa);
            InDanhSach(ketQua, $"KẾT QUẢ TÌM KIẾM THEO TỪ KHÓA '{tuKhoa}'");
        }

        static void SuaDiemSinhVien()
        {
            Console.Write("\nNhập mã sinh viên cần sửa điểm: ");
            string ma = Console.ReadLine()?.Trim() ?? "";
            var sv = ql.TimTheoMa(ma);
            if (sv == null)
            {
                BaoLoi($"Không tìm thấy sinh viên có mã '{ma}'.");
                return;
            }

            Console.WriteLine($"Sinh viên hiện tại: {sv.LayThongTin()}");
            double diemMoi;
            while (true)
            {
                Console.Write("Nhập điểm trung bình mới (0 - 10): ");
                if (double.TryParse(Console.ReadLine(), out diemMoi) && diemMoi >= 0 && diemMoi <= 10)
                {
                    break;
                }
                BaoLoi("Điểm không hợp lệ! Điểm phải là số từ 0 đến 10.");
            }

            ql.Sua(ma, diemMoi);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cập nhật điểm thành công!");
            Console.ResetColor();
        }

        static void XoaSinhVien()
        {
            Console.Write("\nNhập mã sinh viên cần xóa: ");
            string ma = Console.ReadLine()?.Trim() ?? "";
            if (ql.Xoa(ma))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Đã xóa sinh viên '{ma}' thành công!");
                Console.ResetColor();
            }
            else
            {
                BaoLoi($"Không tìm thấy sinh viên có mã '{ma}' để xóa.");
            }
        }

        static void BaoLoi(string thongBao)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[LỖI]: {thongBao}");
            Console.ResetColor();
        }
    }
}
