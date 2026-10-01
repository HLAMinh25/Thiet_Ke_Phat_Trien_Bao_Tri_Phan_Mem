using System;

namespace AnGiangPesticideRefactoring
{
    public class ConsolidateConditionalExpressionBefore
    {
        public double CalculateDiscountRate(int quantityOrdered, bool isVip, bool isHolidaySeason)
        {
            // Các nhánh điều kiện rời rạc nhưng cùng trả về mức chiết khấu 0.15 (15%)
            if (quantityOrdered > 100) return 0.15;
            if (isVip) return 0.15;
            if (isHolidaySeason) return 0.15;

            return 0.05; // Mức chiết khấu mặc định
        }
    }
}