using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal class Program
    {
        private static readonly ProductService service = new ProductService();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            // Đăng ký nhận sự kiện (Event Subscriptions)
            service.OnProductAdded += product =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[EVENT]: Thêm thành công sản phẩm '{product.TenSP}' (Mã: {product.MaSP}) vào hệ thống!");
                Console.ResetColor();
            };

            service.OnProductRemoved += maSP =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[EVENT]: Đã xóa sản phẩm có mã '{maSP}' khỏi hệ thống thành công!");
                Console.ResetColor();
            };

            // Dữ liệu mẫu kiểm thử
            try
            {
                service.AddProduct(new Product("SP01", "Bàn phím cơ AKKO", 1250000, 15));
                service.AddProduct(new Product("SP02", "Chuột Logitech G102", 450000, 30));
                service.AddProduct(new Product("SP03", "Tai nghe Gaming HyperX", 1850000, 8));
            }
            catch (Exception ex)
            {
                BaoLoi(ex.Message);
            }

            int chon = -1;
            do
            {
                HienThiMenu();
                Console.Write("Chon: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out chon) || chon < 0 || chon > 7)
                {
                    BaoLoi("Lựa chọn không hợp lệ! Vui lòng chọn số từ 0 đến 7.");
                    chon = -1;
                    continue;
                }

                try
                {
                    switch (chon)
                    {
                        case 1:
                            ThemSanPhamUI();
                            break;
                        case 2:
                            XuatDanhSachUI(service.GetAllProducts(), "DANH SÁCH TẤT CẢ SẢN PHẨM");
                            break;
                        case 3:
                            TimTheoMaUI();
                            break;
                        case 4:
                            TimTheoTenUI();
                            break;
                        case 5:
                            LocTheoKhoangGiaUI();
                            break;
                        case 6:
                            XoaSanPhamUI();
                            break;
                        case 7:
                            TinhTongGiaTriKhoUI();
                            break;
                        case 0:
                            Console.WriteLine("Đã thoát chương trình. Hẹn gặp lại!");
                            break;
                    }
                }
                catch (DuplicateProductException ex)
                {
                    BaoLoi($"[Lỗi trùng lặp]: {ex.Message}");
                }
                catch (ProductNotFoundException ex)
                {
                    BaoLoi($"[Lỗi không tìm thấy]: {ex.Message}");
                }
                catch (ArgumentException ex)
                {
                    BaoLoi($"[Lỗi tham số dữ liệu]: {ex.Message}");
                }
                catch (Exception ex)
                {
                    BaoLoi($"[Lỗi hệ thống]: {ex.Message}");
                }

            } while (chon != 0);
        }

        static void HienThiMenu()
        {
            Console.WriteLine("\n===== PRODUCT MANAGER =====");
            Console.WriteLine("1. Them san pham");
            Console.WriteLine("2. Xuat danh sach");
            Console.WriteLine("3. Tim theo ma");
            Console.WriteLine("4. Tim theo ten");
            Console.WriteLine("5. Loc theo khoang gia");
            Console.WriteLine("6. Xoa san pham");
            Console.WriteLine("7. Tinh tong gia tri kho");
            Console.WriteLine("0. Thoat");
        }

        static void XuatDanhSachUI(List<Product> list, string tieuDe)
        {
            Console.WriteLine($"\n--- {tieuDe} ---");
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Không có sản phẩm nào để hiển thị.");
                return;
            }

            foreach (var sp in list)
            {
                Console.WriteLine(sp);
            }
        }

        static void ThemSanPhamUI()
        {
            Console.WriteLine("\n--- THÊM SẢN PHẨM MỚI ---");
            string maSP;
            while (true)
            {
                Console.Write("Nhập mã sản phẩm: ");
                maSP = Console.ReadLine()?.Trim() ?? "";
                if (!string.IsNullOrEmpty(maSP)) break;
                BaoLoi("Mã sản phẩm không được để trống!");
            }

            Console.Write("Nhập tên sản phẩm: ");
            string tenSP = Console.ReadLine()?.Trim() ?? "";

            double price = NhapSoThucKhongAm("Nhập đơn giá (VNĐ): ");
            int quantity = NhapSoNguyenKhongAm("Nhập số lượng: ");

            // Ném ngoại lệ DuplicateProductException nếu trùng
            service.AddProduct(new Product(maSP, tenSP, price, quantity));
        }

        static void TimTheoMaUI()
        {
            Console.Write("\nNhập mã sản phẩm cần tìm: ");
            string ma = Console.ReadLine()?.Trim() ?? "";
            var sp = service.GetProductById(ma);
            if (sp != null)
            {
                Console.WriteLine("Kết quả tìm kiếm:");
                Console.WriteLine(sp);
            }
            else
            {
                BaoLoi($"Không tìm thấy sản phẩm có mã '{ma}'.");
            }
        }

        static void TimTheoTenUI()
        {
            Console.Write("\nNhập từ khóa tên sản phẩm cần tìm: ");
            string tuKhoa = Console.ReadLine()?.Trim() ?? "";
            var results = service.SearchByName(tuKhoa);
            XuatDanhSachUI(results, $"KẾT QUẢ TÌM KIẾM CHO '{tuKhoa}'");
        }

        static void LocTheoKhoangGiaUI()
        {
            Console.WriteLine("\n--- LỌC SẢN PHẨM THEO KHOẢNG GIÁ ---");
            double minPrice = NhapSoThucKhongAm("Nhập giá nhỏ nhất (Min): ");
            double maxPrice;
            while (true)
            {
                maxPrice = NhapSoThucKhongAm("Nhập giá lớn nhất (Max): ");
                if (maxPrice >= minPrice) break;
                BaoLoi("Giá lớn nhất phải lớn hơn hoặc bằng giá nhỏ nhất!");
            }

            // Định nghĩa biểu thức Func<Product, bool>
            Func<Product, bool> giaPredicate = p => p.Price >= minPrice && p.Price <= maxPrice;
            var filtered = service.FilterProducts(giaPredicate);

            XuatDanhSachUI(filtered, $"SẢN PHẨM CÓ GIÁ TỪ {minPrice:N0} ĐẾN {maxPrice:N0} VNĐ");
        }

        static void XoaSanPhamUI()
        {
            Console.Write("\nNhập mã sản phẩm cần xóa: ");
            string ma = Console.ReadLine()?.Trim() ?? "";
            // Tự động kích hoạt ProductNotFoundException nếu không tìm thấy
            service.RemoveProduct(ma);
        }

        static void TinhTongGiaTriKhoUI()
        {
            double total = service.CalculateTotalInventoryValue();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n>> TỔNG GIÁ TRỊ TOÀN BỘ KHO HÀNG: {total:N0} VNĐ <<");
            Console.ResetColor();
        }

        // ================= CÁC HÀM NHẬP DỮ LIỆU AN TOÀN =================

        static double NhapSoThucKhongAm(string thongBao)
        {
            double val;
            while (true)
            {
                Console.Write(thongBao);
                string input = Console.ReadLine()?.Trim().Replace(',', '.') ?? "";

                if (double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out val) && val >= 0)
                {
                    return val;
                }
                BaoLoi("Giá trị không hợp lệ! Vui lòng nhập số thực không âm (>= 0).");
            }
        }

        static int NhapSoNguyenKhongAm(string thongBao)
        {
            int val;
            while (true)
            {
                Console.Write(thongBao);
                string input = Console.ReadLine();

                if (int.TryParse(input, out val) && val >= 0)
                {
                    return val;
                }
                BaoLoi("Số lượng không hợp lệ! Vui lòng nhập số nguyên không âm (>= 0).");
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
