using System;

namespace AnGiangPesticideRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHAY THU NGHIEM: DECOMPOSE CONDITIONAL ===");

            // 1. Test Before
            DecomposeConditionalBefore before = new DecomposeConditionalBefore();
            double priceBefore = before.CalculateSeasonPrice(new DateTime(2026, 6, 15), 100000, 1.2);
            Console.WriteLine($"1. Ket qua Before: {priceBefore:N0} VND");

            // 2. Test After
            DecomposeConditionalAfter after = new DecomposeConditionalAfter();
            double priceAfter = after.CalculateSeasonPrice(new DateTime(2026, 6, 15), 100000, 1.2);
            Console.WriteLine($"2. Ket qua After: {priceAfter:N0} VND");

            // 3. Test Real (Nghiệp vụ chiết khấu mùa cao điểm nông dược An Giang)
            DecomposeConditionalReal real = new DecomposeConditionalReal();
            double discountRate = real.CalculatePesticideDiscountRate(60, 1200000, true);
            Console.WriteLine($"3. Ket qua Real (Ty le chiet khau mua vu): {discountRate * 100}%");

            Console.ReadKey();
        }
    }
}