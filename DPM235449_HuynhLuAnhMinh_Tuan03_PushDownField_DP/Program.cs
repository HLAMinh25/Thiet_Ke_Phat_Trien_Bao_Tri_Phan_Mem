using System;

namespace AnGiangPesticideRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHAY THU NGHIEM: PUSH DOWN FIELD ===");

            // 1. Test Before & 2. Test After (Khái niệm cơ bản)
            var insecticide = new InsecticideAfter("Thuốc trừ sâu Anvil", 120000, "Nguy hiem - Tránh xa nguon nuoc");
            var fertilizer = new FoliarFertilizerAfter("Phân bón lá sinh học", 85000);

            Console.WriteLine($"1 & 2. Test After:");
            Console.WriteLine($"- Thuoc tru sau co canh bao: {insecticide.ToxicityWarning}");
            Console.WriteLine($"- Phan bon la duoc lam sach lop cha, khong con thua thoi thuoc tinh canh bao.");

            // 3. Test Real (Nghiệp vụ quản lý kho nông dược An Giang áp dụng Push Down Field)
            Console.WriteLine("\n3. Test Real (Danh muc vat tu kho An Giang):");

            var chemicalItem = new ChemicalInsecticideItem("BVTV-01", "Thuoc Tru Sau Benlate C", 140000, 14);
            chemicalItem.PrintItemSummary();

            Console.WriteLine();

            var organicItem = new OrganicFoliarFertilizerItem("PB-02", "Phan Bon Huu Co An Giang Gold", 95000, 45.0);
            organicItem.PrintItemSummary();

            Console.ReadKey();
        }
    }
}