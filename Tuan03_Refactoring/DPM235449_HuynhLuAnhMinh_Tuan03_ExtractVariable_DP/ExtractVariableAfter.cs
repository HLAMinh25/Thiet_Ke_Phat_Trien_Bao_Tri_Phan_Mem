using System;

namespace AnGiangPesticideRefactoring
{
    public class ExtractVariableAfter
    {
        public double CalculateFinalPrice(double unitPrice, int quantity, double discountRate, double shippingFee)
        {
            // Trích xuất các biến trung gian mang tính tự giải thích (Self-explanatory variables)
            double baseTotalPrice = unitPrice * quantity;
            bool isBulkOrder = baseTotalPrice > 500000;
            double appliedDiscountRate = isBulkOrder ? 0.15 : 0.05;
            double discountAmount = baseTotalPrice * appliedDiscountRate;

            return baseTotalPrice - discountAmount + shippingFee;
        }
    }
}