using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            int[] a = null;
            int chon;

            do
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Nhap mang");
                Console.WriteLine("2. Xuat mang");
                Console.WriteLine("3. Tinh tong");
                Console.WriteLine("4. Tim max/min");
                Console.WriteLine("5. Dem chan/le");
                Console.WriteLine("6. Sap xep tang dan");
                Console.WriteLine("7. Tim kiem");
                Console.WriteLine("0. Thoat");

                chon = NhapSoNguyen("Chon chuc nang: ");

                // Kiểm tra điều kiện chưa nhập mảng cho các chức năng 2 -> 7
                if (chon >= 2 && chon <= 7 && a == null)
                {
                    Console.WriteLine("Lỗi: Bạn chưa nhập mảng! Vui lòng chọn chức năng 1 trước.");
                    continue;
                }
                switch (chon)
                {
                    case 1:
                        a = NhapMang();
                        break;
                    case 2:
                        XuatMang(a);
                        break;
                    case 3:
                        Console.WriteLine($"Tổng các phần tử: {TinhTong(a)}");
                        break;
                    case 4:
                        Console.WriteLine($"Max = {TimMax(a)}, Min = {TimMin(a)}");
                        break;
                    case 5:
                        Console.WriteLine($"Chẵn = {DemChan(a)}, Lẻ = {DemLe(a)}");
                        break;
                    case 6:
                        SapXepTangDan(a);
                        Console.WriteLine("Mảng sau khi sắp xếp tăng dần:");
                        XuatMang(a);
                        break;
                    case 7:
                        int x = NhapSoNguyen("Nhập giá trị x cần tìm: ");
                        int viTri = TimKiem(a, x);
                        if (viTri != -1)
                            Console.WriteLine($"Tìm thấy {x} tại vị trí đầu tiên là {viTri} tinh tu 0");
                        else
                            Console.WriteLine($"Không tìm thấy {x} trong mảng.");
                        break;
                    case 0:
                        Console.WriteLine("Kết thúc chương trình.");
                        break;
                    default:
                        Console.WriteLine("Chức năng không hợp lệ, vui lòng chọn lại!");
                        break;
                }
            } while (chon != 0);
        }

        static int NhapSoNguyen(string message)
        {
            int giaTri;
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out giaTri))
                    return giaTri;
                Console.WriteLine("Giá trị phải là số nguyên, vui lòng nhập lại!");
            }
        }

        static int NhapSoNguyenDuong(string message)
        {
            int n;
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                    return n;
                Console.WriteLine("Lỗi: Số lượng n phải là số nguyên dương (> 0)!");
            }
        }
        static int[] NhapMang()
        {
            int n = NhapSoNguyenDuong("Nhập số lượng phần tử của mảng: ");
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = NhapSoNguyen($"Nhập phần tử thứ {i}: ");
            }
            return a;
        }

        static void XuatMang(int[] a)
        {
            Console.Write("Mảng hiện tại: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        static int TinhTong(int[] a)
        {
            int tong = 0;
            for (int i = 0; i < a.Length; i++)
                tong += a[i];
            return tong;
        }

        static int TimMax(int[] a)
        {
            int max = a[0];
            for (int i= 1; i < a.Length; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }
            return max;
        }

        static int TimMin(int[] a)
        {
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                    min = a[i];
            }
            return min;
        }
        static int DemChan(int[] a)
        {
            int dem = 0;
            for (int i = 0; i < a.Length; i++)
                if (a[i] % 2 == 0) dem++;
            return dem;
        }

        static int DemLe(int[] a)
        {
            int dem = 0;
            for (int i = 0; i < a.Length; i++)
                if (a[i] % 2 != 0) dem++;
            return dem;
        }

        static void SapXepTangDan(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }

        static int TimKiem(int[] a, int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                    return i;
            }
            return -1;
        }

    }
}
