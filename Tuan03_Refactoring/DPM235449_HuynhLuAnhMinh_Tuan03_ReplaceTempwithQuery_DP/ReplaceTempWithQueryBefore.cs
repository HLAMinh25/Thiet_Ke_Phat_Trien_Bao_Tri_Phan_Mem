using System;

namespace AnGiangPesticideRefactoring
{
    public class ReplaceTempWithQueryBefore
    {
        private double unitPrice;
        private int quantity;

        public ReplaceTempWithQueryBefore(double unitPrice, int quantity)
        {
            this.unitPrice = unitPrice;
            this.quantity = quantity;
        }

        // Tính tổng tiền sau khi giảm giá bằng cách dùng biến tạm chứa kết quả trung gian
        public double CalculateTotal()
        {
            double basePrice = unitPrice * quantity;
            double discountFactor = (basePrice > 500000) ? 0.10 : 0.05;

            return basePrice - (basePrice * discountFactor);
        }
    }
}