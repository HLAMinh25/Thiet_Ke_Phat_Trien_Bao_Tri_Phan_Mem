using System;

namespace NongDuocAnGiang.DesignPatterns.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== HỆ THỐNG QUẢN LÝ BÁN HÀNG CÔNG TY NÔNG DƯỢC AN GIANG ===");
            Console.WriteLine("Chức năng: Lập hóa đơn và tính chi phí vận chuyển phát sinh\n");

            // 1. Hệ thống hóa đơn khởi tạo dịch vụ của bên thứ 3 (Adaptee)
            ExternalLogisticsService thirdPartyService = new ExternalLogisticsService();

            // 2. Bọc Adaptee vào bên trong Adapter để tương thích với hệ thống
            IShippingFeeCalculator shippingCalculator = new ShippingFeeAdapter(thirdPartyService);

            // 3. Quá trình lập hóa đơn
            string maHoaDon = "HD-NGAY20-001";
            double khoangCachGiaoHang = 45.5; // km

            Console.WriteLine($"Đang lập hóa đơn: {maHoaDon}");
            Console.WriteLine($"Khoảng cách giao hàng: {khoangCachGiaoHang} km");

            // Client gọi tính phí một cách dễ dàng thông qua interface chuẩn
            decimal shippingCost = shippingCalculator.CalculateShipping(maHoaDon, khoangCachGiaoHang);

            Console.WriteLine($"\n=> Chi phí vận chuyển phát sinh cần cộng vào hóa đơn: {shippingCost:N0} VND");
            Console.WriteLine("Hoàn tất lập hóa đơn!");
            Console.ReadLine();
        }
    }
}