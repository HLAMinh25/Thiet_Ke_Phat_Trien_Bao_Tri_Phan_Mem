using System;

namespace Bai4_Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== BÀI 4: PROTOTYPE - NHÂN BẢN LÔ HÀNG NHẬP KHO ===\n");

            // Tạo lô mẫu ban đầu
            GoodsReceiptNote originalBatch = new GoodsReceiptNote(
                "Thuốc trừ sâu Regent 800WG",
                "Công ty Bayer AG",
                85000m,
                new BatchInfo("BATCH-2026-01", DateTime.Now.AddYears(2))
            );

            Console.WriteLine("Lô hàng gốc:");
            originalBatch.DisplayInfo();

            // Nhân bản thành lô mới
            GoodsReceiptNote newBatch = originalBatch.DeepCopy();
            newBatch.BatchDetail.BatchCode = "BATCH-2026-02"; // Thay đổi mã lô mới
            newBatch.BatchDetail.ExpiryDate = DateTime.Now.AddYears(3); // Hạn dùng mới

            Console.WriteLine("\nLô hàng mới sau khi sao chép và cập nhật:");
            newBatch.DisplayInfo();

            Console.WriteLine("\nKiểm tra lại lô hàng gốc (đảm bảo không bị sửa lây):");
            originalBatch.DisplayInfo();

            Console.ReadLine();
        }
    }
}