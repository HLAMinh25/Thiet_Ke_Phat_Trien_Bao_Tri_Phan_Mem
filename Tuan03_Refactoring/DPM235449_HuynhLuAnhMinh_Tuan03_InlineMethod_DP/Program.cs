using System;

namespace AnGiangPesticideRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // --- KIỂM THỬ INLINE METHOD ---
            Console.WriteLine("\n=== 2. INLINE METHOD BEFORE ===");
            InlineMethodBefore inlineBefore = new InlineMethodBefore();
            Console.WriteLine($"Rating giao hang (Before): {inlineBefore.GetDeliveryRating()}");

            Console.WriteLine("\n=== 3. INLINE METHOD AFTER ===");
            InlineMethodAfter inlineAfter = new InlineMethodAfter();
            Console.WriteLine($"Rating giao hang (After): {inlineAfter.GetDeliveryRating()}");

            Console.WriteLine("\n=== 4. INLINE METHOD REAL (NGHIEP VU NONG DUOC) ===");
            InlineMethodReal inlineReal = new InlineMethodReal();
            Console.WriteLine(inlineReal.CheckBatchPolicyStatus());

            Console.ReadKey();
        }
    }
}