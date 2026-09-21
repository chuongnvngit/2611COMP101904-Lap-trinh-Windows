using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public class DuplicateProductException : Exception
    {
        public DuplicateProductException(string message) : base(message) { }
    }

    // Phát sinh khi tìm kiếm/xóa sản phẩm không tồn tại
    public class ProductNotFoundException : Exception
    {
        public ProductNotFoundException(string message) : base(message) { }
    }
}
