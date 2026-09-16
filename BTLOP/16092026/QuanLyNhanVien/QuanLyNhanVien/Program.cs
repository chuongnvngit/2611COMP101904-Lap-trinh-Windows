using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<NhanVien> danhSach = new List<NhanVien>();

            // Khởi tạo sẵn 5 nhân viên mẫu thuộc các loại khác nhau
            danhSach.Add(new NhanVienVanPhong("VP01", "Nguyễn Văn A", 6000000, 24));
            danhSach.Add(new NhanVienVanPhong("VP02", "Trần Thị B", 5500000, 26));
            danhSach.Add(new NhanVienKinhDoanh("KD01", "Lê Văn C", 5000000, 80000000));
            danhSach.Add(new NhanVienKinhDoanh("KD02", "Phạm Thị D", 5000000, 120000000));
            danhSach.Add(new NhanVienThoiVu("TV01", "Hoàng Văn E", 120, 35000));

            int chon;
            do
            {
                Console.WriteLine("\n========== MENU ==========");
                Console.WriteLine("1. Xuất danh sách nhân viên");
                Console.WriteLine("2. Tìm nhân viên theo mã");
                Console.WriteLine("3. Tìm nhân viên có lương cao nhất");
                Console.WriteLine("4. Tính tổng lương công ty phải trả");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn chức năng: ");

                string input = Console.ReadLine();
                if (!int.TryParse(input, out chon))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Lỗi: Lựa chọn phải là chữ số nguyên. Vui lòng nhập lại!");
                    Console.ResetColor();
                    continue; 
                }

                switch (chon)
                {
                    case 1:
                        Console.WriteLine("\n--- DANH SÁCH NHÂN VIÊN ---");
                        foreach (var nv in danhSach)
                        {
                            nv.HienThiThongTin();
                        }
                        break;

                    case 2:
                        Console.Write("\nNhập mã nhân viên cần tìm: ");
                        string maTim = Console.ReadLine()?.Trim() ?? "";
                        NhanVien timThay = danhSach.Find(nv => nv.MaNV.Equals(maTim, StringComparison.OrdinalIgnoreCase));
                        if (timThay != null)
                        {
                            Console.WriteLine("Tìm thấy nhân viên:");
                            timThay.HienThiThongTin();
                        }
                        else
                        {
                            Console.WriteLine($"Không tìm thấy nhân viên có mã '{maTim}'.");
                        }
                        break;

                    case 3:
                        if (danhSach.Count == 0)
                        {
                            Console.WriteLine("Danh sách đang trống!");
                            break;
                        }

                        NhanVien nvMaxLuong = danhSach[0];
                        foreach (var nv in danhSach)
                        {
                            if (nv.TinhLuong() > nvMaxLuong.TinhLuong())
                            {
                                nvMaxLuong = nv;
                            }
                        }

                        Console.WriteLine("\n--- NHÂN VIÊN CÓ LƯƠNG CAO NHẤT ---");
                        nvMaxLuong.HienThiThongTin();
                        break;

                    case 4:
                        double tongLuong = 0;
                        foreach (var nv in danhSach)
                        {
                            tongLuong += nv.TinhLuong();
                        }
                        Console.WriteLine($"\nTổng quỹ lương công ty phải trả: {tongLuong:N0} VNĐ");
                        break;

                    case 0:
                        Console.WriteLine("Đang thoát chương trình...");
                        break;

                    default:
                        Console.WriteLine("Chức năng không hợp lệ, vui lòng chọn lại!");
                        break;
                }

            } while (chon != 0);
        }
    }
}
