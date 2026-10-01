using System;

namespace AnGiangPesticideRefactoring
{
    public class ParameterizeMethodBefore
    {
        // Các phương thức riêng biệt bị trùng lặp logic tính toán
        public double TenPercentDiscount(double baseAmount)
        {
            return baseAmount * 0.90;
        }

        public double FifteenPercentDiscount(double baseAmount)
        {
            return baseAmount * 0.85;
        }
    }
}