using System;

namespace AnGiangPesticideRefactoring
{
    // Lớp cơ sở chung cho các lô hàng xuất kho nông dược (Pull Up Constructor Body Target)
    public abstract class PesticideExportBatchBase
    {
        public string BatchCode { get; set; }
        public int Quantity { get; set; }
        public DateTime ExportDate { get; set; }

        // Constructor của lớp cha chứa logic khởi tạo chung được Pull Up lên
        protected PesticideExportBatchBase(string batchCode, int quantity)
        {
            // Kiểm tra tính hợp lệ và khởi tạo chung cho mọi lô hàng xuất kho
            if (string.IsNullOrWhiteSpace(batchCode))
            {
                throw new ArgumentException("Ma lo hang khong duoc de trong!");
            }

            BatchCode = batchCode.Trim().ToUpper();
            Quantity = quantity > 0 ? quantity : throw new ArgumentException("So luong xuat kho phai lon hon 0!");
            ExportDate = DateTime.Now; // Tự động gán thời gian xuất kho thực tế

            Console.WriteLine($"[Kho An Giang] Khoi tao thanh cong thong tin chung cho lo: {BatchCode} (SL: {Quantity})");
        }
    }

    // Lớp con 1: Lô thuốc trừ sâu xuất kho
    public class InsecticideExportBatchReal : PesticideExportBatchBase
    {
        public string ActiveIngredient { get; set; } // Hoạt chất đặc thù của thuốc trừ sâu

        public InsecticideExportBatchReal(string batchCode, int quantity, string activeIngredient)
            : base(batchCode, quantity) // Kế thừa phần thân constructor từ lớp cha (Pull Up Constructor Body)
        {
            ActiveIngredient = activeIngredient;
        }

        public void PrintBatchDetails()
        {
            Console.WriteLine($"-> Loai: Thuốc trừ sâu | Hoat chat: {ActiveIngredient} | Ngay xuat: {ExportDate:dd/MM/yyyy HH:mm}");
        }
    }

    // Lớp con 2: Lô phân bón lá xuất kho
    public class FoliarFertilizerExportBatchReal : PesticideExportBatchBase
    {
        public double NutrientPercentage { get; set; } // Tỷ lệ dinh dưỡng đặc thù của phân bón lá

        public FoliarFertilizerExportBatchReal(string batchCode, int quantity, double nutrientPercentage)
            : base(batchCode, quantity) // Kế thừa phần thân constructor từ lớp cha (Pull Up Constructor Body)
        {
            NutrientPercentage = nutrientPercentage;
        }

        public void PrintBatchDetails()
        {
            Console.WriteLine($"-> Loai: Phân bón lá | Ham luong dinh duong: {NutrientPercentage}% | Ngay xuat: {ExportDate:dd/MM/yyyy HH:mm}");
        }
    }
}