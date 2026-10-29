using System;

namespace AnGiangPesticideRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHAY THU NGHIEM: PULL UP CONSTRUCTOR BODY ===");

            // 1. Test Before & 2. Test After (Khái niệm cơ bản)
            var retailItem = new RetailOrderItemAfter("Thuốc trừ sâu Anvil", 120000, 10);
            Console.WriteLine($"1 & 2. Test After (Khoi tao tu lop cha): San pham '{retailItem.Name}' - Gia: {retailItem.Price:N0} VND");

            // 3. Test Real (Nghiệp vụ xuất kho lô nông dược An Giang áp dụng Pull Up Constructor Body)
            Console.WriteLine("\n3. Test Real (Xuat kho cac lo nong duoc):");

            var insecticideBatch = new InsecticideExportBatchReal("lo-bvtv-01", 150, "Hexaconazole");
            insecticideBatch.PrintBatchDetails();

            Console.WriteLine();

            var fertilizerBatch = new FoliarFertilizerExportBatchReal("lo-pb-02", 300, 30.5);
            fertilizerBatch.PrintBatchDetails();

            Console.ReadKey();
        }
    }
}