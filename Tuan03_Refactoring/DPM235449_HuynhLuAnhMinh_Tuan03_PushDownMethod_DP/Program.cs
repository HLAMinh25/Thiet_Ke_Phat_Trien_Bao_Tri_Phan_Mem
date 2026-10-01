using System;

namespace AnGiangPesticideRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHAY THU NGHIEM: PUSH DOWN METHOD ===");

            // 1. Test Before & 2. Test After (Khái niệm cơ bản)
            var insecticide = new InsecticideAfter("Thuốc trừ sâu Anvil", 150000);
            double tax = insecticide.CalculateSpecialHazardTax();
            Console.WriteLine($"1 & 2. Test After (Tinh thue dac biet o lop con): {tax:N0} VND");

            // 3. Test Real (Nghiệp vụ quản lý kho nông dược An Giang áp dụng Push Down Method)
            Console.WriteLine("\n3. Test Real (Xu ly chung tu kho An Giang):");

            var sprayProduct = new ChemicalSprayProduct("BVTV-99", "Thuốc Trừ Sâu Benlate C", 130000, "Nhom Doc II");
            sprayProduct.PrintInfo();

            // Gọi phương thức được Push Down xuống đúng lớp con ChemicalSprayProduct
            sprayProduct.GenerateQuarantineCertificate();

            Console.WriteLine();

            var organicFertilizer = new OrganicLeafFertilizerProduct("PB-88", "Phân Bón Lá Hữu Cơ An Giang Gold", 90000, "Viet Nam");
            organicFertilizer.PrintInfo();
            // Lưu ý: Phân bón lá organic không có phương thức GenerateQuarantineCertificate() giúp lớp cha và đối tượng này gọn gàng, đúng nghiệp vụ.

            Console.ReadKey();
        }
    }
}