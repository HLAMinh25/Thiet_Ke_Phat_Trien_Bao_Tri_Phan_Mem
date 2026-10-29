using System;

namespace AnGiangPesticideRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHAY THU NGHIEM: REPLACE CONDITIONAL WITH POLYMORPHISM ===");

            // 1. Test Before
            ProductBefore productBefore = new ProductBefore("ThuocTruSau", 200000);
            Console.WriteLine($"1. Ket qua Before (Gia sau chiet khau): {productBefore.CalculateDiscountedPrice():N0} VND");

            // 2. Test After
            PesticideProductAfter productAfter = new InsecticideAfter(200000);
            Console.WriteLine($"2. Ket qua After (Gia sau chiet khau da hinh): {productAfter.CalculateDiscountedPrice():N0} VND");

            // 3. Test Real (Nghiệp vụ vận chuyển và xử lý lô nông dược An Giang áp dụng Polymorphism)
            // Lô hàng 1: Thuốc trừ sâu độc tính cao
            var batchInsecticide = new ReplaceConditionalWithPolymorphismReal(
                "LO-BVTV-01",
                "Thuoc Tru Sau Anvil 5SC",
                1500000,
                new HighToxicityInsecticidePolicy()
            );

            Console.WriteLine("\n3. Ket qua Real (Lo 1 - Thuoc tru sau):");
            batchInsecticide.PrintBatchPolicyDetails();

            // Lô hàng 2: Phân bón sinh học
            var batchFertilizer = new ReplaceConditionalWithPolymorphismReal(
                "LO-PB-02",
                "Phan Bon Huu Co An Giang Gold",
                800000,
                new OrganicFertilizerPolicy()
            );

            Console.WriteLine("\nKet qua Real (Lo 2 - Phan bon sinh hoc):");
            batchFertilizer.PrintBatchPolicyDetails();

            Console.ReadKey();
        }
    }
}