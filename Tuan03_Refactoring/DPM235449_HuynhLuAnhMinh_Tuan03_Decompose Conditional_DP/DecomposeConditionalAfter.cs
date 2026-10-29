using System;

namespace AnGiangPesticideRefactoring
{
    public class DecomposeConditionalAfter
    {
        private DateTime summerStartDate = new DateTime(2026, 5, 1);
        private DateTime summerEndDate = new DateTime(2026, 8, 31);

        public double CalculateSeasonPrice(DateTime currentDate, double basePrice, double premiumRate)
        {
            // Phân rã điều kiện thành các hàm có tên gọi rõ nghĩa
            if (IsSummerSeason(currentDate))
            {
                return SummertimePrice(basePrice, premiumRate);
            }
            else
            {
                return RegularPrice(basePrice);
            }
        }

        private bool IsSummerSeason(DateTime date)
        {
            return date >= summerStartDate && date <= summerEndDate;
        }

        private double SummertimePrice(double basePrice, double premiumRate)
        {
            return basePrice * premiumRate;
        }

        private double RegularPrice(double basePrice)
        {
            return basePrice * 0.90;
        }
    }
}