using System;

namespace AnGiangPesticideRefactoring
{
    public class ParameterizeMethodAfter
    {
        // Áp dụng Parameterize Method: Tham số hóa tỷ lệ chiết khấu vào chung một phương thức
        public double CalculateDiscountedAmount(double baseAmount, double discountRate)
        {
            return baseAmount * (1.0 - discountRate);
        }
    }
}