using System;

namespace AnGiangPesticideRefactoring
{
    public class DecomposeConditionalBefore
    {
        private DateTime summerStartDate = new DateTime(2026, 5, 1);
        private DateTime summerEndDate = new DateTime(2026, 8, 31);

        public double CalculateSeasonPrice(DateTime currentDate, double basePrice, double premiumRate)
        {
            double finalPrice;
            // Biểu thức điều kiện phức tạp gộp chung trong câu lệnh if
            if (currentDate < summerStartDate || currentDate > summerEndDate)
            {
                finalPrice = basePrice * 0.90; // Mùa thấp điểm giảm giá 10%
            }
            else
            {
                finalPrice = basePrice * premiumRate; // Mùa cao điểm tính theo hệ số phụ thu
            }
            return finalPrice;
        }
    }
}