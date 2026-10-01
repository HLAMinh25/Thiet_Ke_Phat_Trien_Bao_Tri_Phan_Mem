using System;

namespace AnGiangPesticideRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHAY THU NGHIEM: INLINE CLASS ===");

            // 1. Test Before
            var phoneBefore = new AgencyPhoneNumberBefore("0296", "3852111");
            InlineClassBefore before = new InlineClassBefore("Dai ly Nong duoc Bay Long", phoneBefore);
            Console.WriteLine("1. Ket qua Before:");
            before.PrintInfo();

            // 2. Test After
            InlineClassAfter after = new InlineClassAfter("Dai ly Nong duoc Bay Long", "0296", "3852111");
            Console.WriteLine("\n2. Ket qua After:");
            after.PrintInfo();

            // 3. Test Real (Nghiệp vụ vị trí tồn kho lô nông dược An Giang sau khi Inline Class)
            InlineClassReal real = new InlineClassReal("LO-BVTV-2026-X", "Thuoc Tru Sau Anvil 5SC", 250, "A2", "Kệ 05");
            Console.WriteLine("\n3. Ket qua Real:");
            real.PrintBatchLocationSummary();

            Console.ReadKey();
        }
    }
}