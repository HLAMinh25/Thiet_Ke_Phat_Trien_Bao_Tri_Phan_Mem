using System;

namespace AnGiangPesticideRefactoring
{
    public class InlineTempBefore
    {
        // Biến tạm `basePrice` chỉ dùng một lần duy nhất để chứa giá trị tính toán
        public bool IsOrderEligibleForDiscount(double unitPrice, int quantity)
        {
            double basePrice = unitPrice * quantity;
            return basePrice > 500000;
        }
    }
}