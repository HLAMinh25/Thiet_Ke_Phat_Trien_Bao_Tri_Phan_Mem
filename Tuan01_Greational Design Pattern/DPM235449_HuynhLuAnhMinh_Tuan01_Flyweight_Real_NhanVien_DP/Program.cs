using System;

namespace NongDuocAnGiang.DesignPatterns.Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== HỆ THỐNG THỐNG KÊ TỒN KHO NÔNG DƯỢC ===");

            // 1. Khởi tạo Factory với một vài sản phẩm gốc có sẵn trong kho
            var factory = new FlyweightFactory(
                new ProductSharedState("Thuốc trừ sâu sinh học A1", "Thuốc bảo vệ thực vật", "Chai"),
                new ProductSharedState("Phân bón NPK Cao cấp", "Phân bón", "Bao")
            );

            factory.ListFlyweights();

            // 2. Client ghi nhận các giao dịch xuất/nhập lô (Hàng ngàn giao dịch nhưng không tốn thêm RAM cho thông tin sản phẩm)
            AddTransactionToDatabase(factory,
                new ProductSharedState("Thuốc trừ sâu sinh học A1", "Thuốc bảo vệ thực vật", "Chai"),
                new TransactionUniqueState("LO-T10-001", new DateTime(2026, 10, 05), 500, "Nhập")
            );

            AddTransactionToDatabase(factory,
                new ProductSharedState("Thuốc trừ sâu sinh học A1", "Thuốc bảo vệ thực vật", "Chai"),
                new TransactionUniqueState("LO-T10-001", new DateTime(2026, 10, 15), 100, "Xuất")
            );

            // Ghi nhận một sản phẩm mới chưa có trong hệ thống, Factory sẽ tự cấp phát
            AddTransactionToDatabase(factory,
                new ProductSharedState("Thuốc diệt cỏ X", "Thuốc bảo vệ thực vật", "Chai"),
                new TransactionUniqueState("LO-T11-099", new DateTime(2026, 11, 01), 250, "Nhập")
            );

            factory.ListFlyweights();

            Console.ReadLine();
        }

        // Helper method mô phỏng việc thêm giao dịch vào thống kê
        static void AddTransactionToDatabase(FlyweightFactory factory, ProductSharedState shared, TransactionUniqueState unique)
        {
            // Lấy Flyweight từ pool
            var flyweight = factory.GetFlyweight(shared);

            // Chuyển dữ liệu context riêng biệt vào để xử lý
            flyweight.ProcessTransaction(unique);
        }
    }
}