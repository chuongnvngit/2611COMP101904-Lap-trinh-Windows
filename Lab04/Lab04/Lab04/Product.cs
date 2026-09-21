using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public class Product : IEntity
    {
        private double price;
        private int quantity;

        public string MaSP { get; set; }
        public string TenSP { get; set; }

        // Triển khai explicit/implicit từ IEntity
        public string Id => MaSP;

        public double Price
        {
            get => price;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Đơn giá không được âm.");
                price = value;
            }
        }

        public int Quantity
        {
            get => quantity;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Số lượng không được âm.");
                quantity = value;
            }
        }

        public Product() { }

        public Product(string maSP, string tenSP, double price, int quantity)
        {
            if (string.IsNullOrWhiteSpace(maSP))
                throw new ArgumentException("Mã sản phẩm không được để trống.");

            MaSP = maSP.Trim();
            TenSP = tenSP?.Trim() ?? "";
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Mã: {MaSP,-8} | Tên: {TenSP,-20} | Đơn giá: {Price,12:N0} VNĐ | SL: {Quantity,4} | Thành tiền: {(Price * Quantity),14:N0} VNĐ";
        }
    }
}
