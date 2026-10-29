using System;

namespace AnGiangPesticideRefactoring
{
    public class SelfEncapsulateFieldReal
    {
        private string productName;
        private double baseUnitPrice; // Trường nội bộ cần đóng gói

        public SelfEncapsulateFieldReal(string productName, double initialUnitPrice)
        {
            this.productName = productName;
            SetBaseUnitPrice(initialUnitPrice); // Gọi setter tự đóng gói ngay khi khởi tạo
        }

        // --- Self Encapsulate Field: Getter và Setter ---
        protected double GetBaseUnitPrice()
        {
            return baseUnitPrice;
        }

        protected void SetBaseUnitPrice(double newPrice)
        {
            // Nghiệp vụ thực tế: Kiểm tra ràng buộc biên độ giá thuốc nông dược không được âm
            if (newPrice <= 0)
            {
                throw new ArgumentException("Don gia vat tu nông nghiep phai lon hon 0!");
            }
            baseUnitPrice = newPrice;
        }

        // Phương thức nghiệp vụ tính toán giá trị lô hàng xuất kho sử dụng getter/setter nội bộ
        public double CalculateBatchValueWithDiscount(int quantity, double seasonalDiscountRate)
        {
            // Truy xuất qua GetBaseUnitPrice() thay vì gọi trực tiếp biến baseUnitPrice
            double standardSubTotal = GetBaseUnitPrice() * quantity;
            double finalAmount = standardSubTotal - (standardSubTotal * seasonalDiscountRate);

            return finalAmount;
        }

        public void ApplyNewMarketPrice(double newPrice)
        {
            SetBaseUnitPrice(newPrice);
            Console.WriteLine($"[Nong Duoc An Giang] Cap nhat don gia thanh cong cho '{productName}': {GetBaseUnitPrice():N0} VND/don vi");
        }
    }
}