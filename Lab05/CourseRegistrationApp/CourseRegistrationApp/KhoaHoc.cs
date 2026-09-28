using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistrationApp
{
    public class KhoaHoc
    {
        public string TenKhoaHoc { get; set; }
        public decimal HocPhiMotThang { get; set; }

        public KhoaHoc(string tenKhoaHoc, decimal hocPhi)
        {
            TenKhoaHoc = tenKhoaHoc;
            HocPhiMotThang = hocPhi;
        }

        public override string ToString()
        {
            return TenKhoaHoc;
        }
    }
}
