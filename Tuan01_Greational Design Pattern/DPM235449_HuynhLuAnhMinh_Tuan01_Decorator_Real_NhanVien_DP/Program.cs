using System;

namespace NongDuocAnGiang.DesignPatterns.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== HỆ THỐNG LẬP HÓA ĐƠN CÔNG TY NÔNG DƯỢC ===");

            // Bước 1: Khởi tạo hóa đơn cơ bản với tiền hàng là 5,000,000 VND
            IInvoice invoice = new BaseInvoice(5000000m);
            Console.WriteLine("\n[1] Khởi tạo hóa đơn cơ bản:");
            Console.WriteLine($"Nội dung:\n{invoice.GetDescription()}");
            Console.WriteLine($"Tổng tiền: {invoice.CalculateTotal():N0} VND");

            // Bước 2: Khách yêu cầu giao hàng tận nơi (Thêm phí vận chuyển 150,000 VND)
            invoice = new ShippingFeeDecorator(invoice, 150000m);

            // Bước 3: Khách thuê thêm dịch vụ bốc xếp (Thêm phí 50,000 VND)
            invoice = new AdditionalServiceDecorator(invoice, "Bốc xếp vào kho", 50000m);

            // Bước 4: Khách hàng VIP được giảm giá khuyến mãi 200,000 VND
            invoice = new DiscountDecorator(invoice, 200000m);

            Console.WriteLine("\n[2] Hóa đơn sau khi tính toán các chi phí phát sinh và giảm giá:");
            Console.WriteLine($"Nội dung chi tiết:\n{invoice.GetDescription()}");
            Console.WriteLine($"\n=> TỔNG THANH TOÁN CUỐI CÙNG: {invoice.CalculateTotal():N0} VND");

            Console.ReadLine();
        }
    }
}