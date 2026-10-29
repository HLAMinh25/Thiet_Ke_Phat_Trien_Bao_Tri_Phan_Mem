using System;

namespace AnGiangPesticideRefactoring
{
    public class SelfEncapsulateFieldAfter
    {
        private double price;

        public SelfEncapsulateFieldAfter(double initialPrice)
        {
            SetPrice(initialPrice); // Sử dụng setter nội bộ ngay cả trong constructor
        }

        // Getter cho trường dữ liệu
        protected double GetPrice()
        {
            return price;
        }

        // Setter cho trường dữ liệu (có thể dễ dàng thêm logic validation hoặc logging tại đây)
        protected void SetPrice(double newPrice)
        {
            if (newPrice < 0) throw new ArgumentException("Gia khong duoc am!");
            price = newPrice;
        }

        // Cập nhật phương thức sử dụng thông qua getter và setter tự đóng gói
        public void RaisePrice(double percentage)
        {
            SetPrice(GetPrice() + (GetPrice() * percentage / 100));
            Console.WriteLine($"[After] Gia ban qua Encapsulate Field: {GetPrice():N0} VND");
        }
    }
}