using System;

namespace NongDuocAnGiang.DesignPatterns.Bridge
{
    public class FifoPriceCalculator : IPriceCalculationStrategy
    {
        public decimal CalculateBaseExportPrice(string productCode, int quantity)
        {
            Console.WriteLine($"   [Database] Đang truy xuất lô hàng cũ nhất của mã {productCode}...");
            Console.WriteLine($"   [Tính toán] Áp dụng phương pháp NHẬP TRƯỚC XUẤT TRƯỚC (FIFO).");

            // Giả lập logic lấy giá vốn từ lô hàng cũ nhất
            decimal unitPrice = 120000m;
            return unitPrice * quantity;
        }
    }
}