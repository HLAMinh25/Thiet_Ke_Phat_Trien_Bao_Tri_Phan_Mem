using System;

namespace AnGiangPesticideRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHAY THU NGHIEM: PULL UP FIELD ===");

            // 1. Test Before & 2. Test After (Khái niệm cơ bản)
            InsecticideAfter insect = new InsecticideAfter("Benlate C", 120000, 2.5);
            Console.WriteLine($"1 & 2. Test After (Ke thừa tu lop cha chung): San pham '{insect.ProductName}' - Gia: {insect.BasePrice:N0} VND");

            // 3. Test Real (Nghiệp vụ quản lý lô hàng tồn kho nông dược An Giang áp dụng Pull Up Field)
            var liquidBatch = new LiquidInsecticideBatch("LO-LIQUID-2026", new DateTime(2026, 3, 10), 500.0);
            var granularBatch = new GranularFungicideBatch("LO-GRANULAR-2026", new DateTime(2026, 4, 15), 250.0);

            Console.WriteLine("\n3. Test Real (Thong tin lo hang ton kho):");
            liquidBatch.PrintLiquidDetails();
            Console.WriteLine();
            granularBatch.PrintGranularDetails();

            Console.ReadKey();
        }
    }
}