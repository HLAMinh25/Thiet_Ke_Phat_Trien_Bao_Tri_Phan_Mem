using System;

namespace AnGiangPesticideRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHAY THU NGHIEM: MOVE METHOD ===");

            // 1. Test Before
            var catBefore = new PesticideCategoryBefore("Thuoc Tru Sau", 100000, 0.05);
            MoveMethodBefore moveBefore = new MoveMethodBefore("LO-01", 10, catBefore);
            Console.WriteLine($"1. Ket qua Before (Gia tri lo hang): {moveBefore.CalculateTotalBatchValue():N0} VND");

            // 2. Test After
            var catAfter = new PesticideCategoryAfter("Thuoc Tru Sau", 100000, 0.05);
            MoveMethodAfter moveAfter = new MoveMethodAfter("LO-01", 10, catAfter);
            Console.WriteLine($"2. Ket qua After (Gia tri lo hang): {moveAfter.GetBatchValue():N0} VND");

            // 3. Test Real (Nghiệp vụ xả kho lô nông dược cận date An Giang)
            var inventoryBatch = new InventoryBatchReal("LO-BVTV-EXPIRED-SOON", 15, 150000, 20); // Còn 15 ngày hết hạn
            MoveMethodReal moveReal = new MoveMethodReal("HD-2026-001", inventoryBatch);
            Console.WriteLine($"3. Ket qua Real (Thanh toan lo xa kho nong duoc): {moveReal.GetFinalBatchAmount():N0} VND");

            Console.ReadKey();
        }
    }
}