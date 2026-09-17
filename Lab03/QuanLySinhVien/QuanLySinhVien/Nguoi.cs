using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    public class Nguoi
    {
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }

        public Nguoi() { }

        public Nguoi(string hoTen, DateTime ngaySinh)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
        }

        public virtual string LayThongTin()
        {
            return $"Họ tên: {HoTen,-18} | Ngày sinh: {NgaySinh:dd/MM/yyyy}";
        }
    }
}
