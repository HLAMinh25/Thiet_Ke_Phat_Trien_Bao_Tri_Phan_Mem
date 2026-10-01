using System;

namespace AnGiangPesticideRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHAY THU NGHIEM: CONSOLIDATE CONDITIONAL EXPRESSION ===");

            // 1. Test Before
            ConsolidateConditionalExpressionBefore before = new ConsolidateConditionalExpressionBefore();
            Console.WriteLine($"1. Ket qua Before (Ty le chiet khau): {before.CalculateDiscountRate(10, false, false) * 100}%");

            // 2. Test After
            ConsolidateConditionalExpressionAfter after = new ConsolidateConditionalExpressionAfter();
            Console.WriteLine($"2. Ket qua After (Ty le chiet khau): {after.CalculateDiscountRate(10, true, false) * 100}%");

            // 3. Test Real (Nghiệp vụ miễn phí ship lô hàng nông dược An Giang)
            ConsolidateConditionalExpressionReal real = new ConsolidateConditionalExpressionReal();
            // Thử nghiệm với đại lý không phải cấp 1, giá trị đơn hàng nhỏ, nhưng nằm trong vụ mùa khuyến mãi
            bool isEligible = real.CheckFreeShippingEligibility(800000, false, true);
            Console.WriteLine($"3. Ket qua Real (Duoc mien phi ship?): {isEligible}");

            Console.ReadKey();
        }
    }
}