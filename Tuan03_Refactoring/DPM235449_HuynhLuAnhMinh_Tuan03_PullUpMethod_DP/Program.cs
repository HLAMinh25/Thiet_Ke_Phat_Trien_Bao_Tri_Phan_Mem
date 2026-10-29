using System;

namespace AnGiangPesticideRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHAY THU NGHIEM: PULL UP METHOD ===");

            // 1. Test Before & 2. Test After (Khái niệm cơ bản)
            LocalOrderAfter localOrder = new LocalOrderAfter();
            double vat = localOrder.CalculateVatTax(1000000);
            Console.WriteLine($"1 & 2. Test After (Tinh thue VAT tu lop cha): {vat:N0} VND");

            // 3. Test Real (Nghiệp vụ chuẩn hóa mã lô hàng nông dược An Giang áp dụng Pull Up Method)
            var importedBatch = new ImportedInsecticideBatchReal("  lo-ag-import-2026  ", "Nhat Ban");
            var domesticBatch = new DomesticFungicideBatchReal("lo-ag-local-2026", "Nha may Can Tho");

            Console.WriteLine("\n3. Test Real (Chuan hoa ma lo hang thong qua Pull Up Method):");

            Console.Write("Lo nhap khau: ");
            string formattedImportCode = importedBatch.FormatAndValidateBatchCode();

            Console.Write("Lo noi dia: ");
            string formattedDomesticCode = domesticBatch.FormatAndValidateBatchCode();

            Console.ReadKey();
        }
    }
}