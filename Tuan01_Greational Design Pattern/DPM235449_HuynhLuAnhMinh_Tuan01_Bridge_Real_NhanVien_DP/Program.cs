using System;

namespace NongDuocAnGiang.DesignPatterns.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== HỆ THỐNG QUẢN LÝ BÁN HÀNG NÔNG DƯỢC ===");

            string maNongDuoc = "ND-THUOC-TRUSAU-01";
            int soLuong = 100;

            // --- TRƯỜNG HỢP 1: Bán Sỉ + Phương pháp Nhập trước Xuất trước ---
            IPriceCalculationStrategy fifoStrategy = new FifoPriceCalculator();
            SalesOrder wholesaleOrder = new WholesaleOrder(fifoStrategy);
            wholesaleOrder.ProcessOrder(maNongDuoc, soLuong);

            // --- TRƯỜNG HỢP 2: Bán Sỉ + Phương pháp Bình quân gia quyền ---
            IPriceCalculationStrategy averageStrategy = new WeightedAveragePriceCalculator();
            // Đổi phương pháp tính giá (thay cầu nối) ngay lúc runtime mà không cần tạo class mới
            wholesaleOrder.SetPriceCalculator(averageStrategy);
            wholesaleOrder.ProcessOrder(maNongDuoc, soLuong);

            // --- TRƯỜNG HỢP 3: Bán Lẻ + Phương pháp Bình quân gia quyền ---
            SalesOrder retailOrder = new RetailOrder(averageStrategy);
            retailOrder.ProcessOrder(maNongDuoc, 5); // Bán lẻ số lượng ít

            Console.ReadLine();
        }
    }
}