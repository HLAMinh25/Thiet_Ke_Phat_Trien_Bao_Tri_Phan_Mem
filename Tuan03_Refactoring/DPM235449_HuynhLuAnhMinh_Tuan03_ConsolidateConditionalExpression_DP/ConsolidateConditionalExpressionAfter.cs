using System;

namespace AnGiangPesticideRefactoring
{
    public class ConsolidateConditionalExpressionAfter
    {
        public double CalculateDiscountRate(int quantityOrdered, bool isVip, bool isHolidaySeason)
        {
            // Gộp các điều kiện chung kết quả lại bằng toán tử OR (||)
            if (IsEligibleForHighDiscount(quantityOrdered, isVip, isHolidaySeason))
            {
                return 0.15;
            }

            return 0.05;
        }

        private bool IsEligibleForHighDiscount(int quantityOrdered, bool isVip, bool isHolidaySeason)
        {
            return quantityOrdered > 100 || isVip || isHolidaySeason;
        }
    }
}