using System;

namespace AnGiangPesticideRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHAY THU NGHIEM: RENAME METHOD ===");

            // 1. Test Before
            RenameMethodBefore before = new RenameMethodBefore();
            double resultBefore = before.Calc(150000, 5);
            Console.WriteLine($"1. Ket qua Before (Ham Calc mo ho): {resultBefore:N0} VND");

            // 2. Test After
            RenameMethodAfter after = new RenameMethodAfter();
            double resultAfter = after.CalculateTotalMerchandiseValue(150000, 5);
            Console.WriteLine($"2. Ket qua After (Ham da doi ten ro nghia): {resultAfter:N0} VND");

            // 3. Test Real (Nghiệp vụ kiểm tra an toàn và duyệt xuất kho nông dược An Giang)
            var batchRecord = new RenameMethodReal("LO-BVTV-BENLATE-09", 60, true);

            Console.WriteLine("\n3. Test Real:");
            bool isApproved = batchRecord.VerifyBatchSafetyAndApproveExport();
            Console.WriteLine($"-> Trang thai phe duyet xuat kho: {isApproved}");

            Console.ReadKey();
        }
    }
}