using System;

namespace AnGiangPesticideRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHAY THU NGHIEM: REPLACE TEMP WITH QUERY ===");

            // 1. Test Before
            ReplaceTempWithQueryBefore before = new ReplaceTempWithQueryBefore(120000, 6);
            Console.WriteLine($"1. Ket qua Before: {before.CalculateTotal():N0} VND");

            // 2. Test After
            ReplaceTempWithQueryAfter after = new ReplaceTempWithQueryAfter(120000, 6);
            Console.WriteLine($"2. Ket qua After: {after.CalculateTotal():N0} VND");

            // 3. Test Real (Nghiệp vụ xuất kho lô nông dược An Giang)
            ReplaceTempWithQueryReal real = new ReplaceTempWithQueryReal("LO-BVTV-2026-A", 150000, 10, 40000);
            Console.WriteLine($"3. Ket qua Real (Thanh toan lo hang nong duoc): {real.CalculateFinalBatchBill():N0} VND");

            Console.ReadKey();
        }
    }
}