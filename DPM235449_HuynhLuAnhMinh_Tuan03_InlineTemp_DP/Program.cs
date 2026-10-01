using System;

namespace AnGiangPesticideRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHAY THU NGHIEM: INLINE TEMP ===");

            // 1. Test Before
            InlineTempBefore before = new InlineTempBefore();
            bool resultBefore = before.IsOrderEligibleForDiscount(100000, 6);
            Console.WriteLine($"1. Ket qua Before (Co du dieu kien chiet khau?): {resultBefore}");

            // 2. Test After
            InlineTempAfter after = new InlineTempAfter();
            bool resultAfter = after.IsOrderEligibleForDiscount(100000, 6);
            Console.WriteLine($"2. Ket qua After (Co du dieu kien chiet khau?): {resultAfter}");

            // 3. Test Real (Nghiệp vụ Nông dược An Giang)
            InlineTempReal real = new InlineTempReal();
            bool resultReal = real.CheckFreeShippingCondition(150000, 12, 300000);
            Console.WriteLine($"3. Ket qua Real (Mien phi van chuyen lo nong duoc?): {resultReal}");

            Console.ReadKey();
        }
    }
}