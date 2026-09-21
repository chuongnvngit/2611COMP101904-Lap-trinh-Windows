using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public class ProductService
    {
        private readonly Repository<Product> repository = new Repository<Product>();

        // Khai báo Action events thông báo khi thêm/xóa thành công
        public event Action<Product> OnProductAdded;
        public event Action<string> OnProductRemoved;

        public void AddProduct(Product product)
        {
            if (repository.FindById(product.MaSP) != null)
            {
                throw new DuplicateProductException($"Mã sản phẩm '{product.MaSP}' đã tồn tại trong hệ thống.");
            }

            repository.Add(product);

            // Bắn event khi thêm thành công
            OnProductAdded?.Invoke(product);
        }

        public void RemoveProduct(string maSP)
        {
            var product = repository.FindById(maSP);
            if (product == null)
            {
                throw new ProductNotFoundException($"Không tìm thấy sản phẩm có mã '{maSP}' để xóa.");
            }

            repository.Remove(maSP);

            // Bắn event khi xóa thành công
            OnProductRemoved?.Invoke(maSP);
        }

        public Product GetProductById(string maSP)
        {
            return repository.FindById(maSP);
        }

        public List<Product> SearchByName(string keyword)
        {
            return repository.Find(p => p.TenSP.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        // Lọc sản phẩm dùng Func<Product, bool> theo khoảng giá
        public List<Product> FilterProducts(Func<Product, bool> predicate)
        {
            return repository.Find(predicate);
        }

        public List<Product> GetAllProducts()
        {
            return repository.GetAll();
        }

        public double CalculateTotalInventoryValue()
        {
            return repository.GetAll().Sum(p => p.Price * p.Quantity);
        }
    }
}
