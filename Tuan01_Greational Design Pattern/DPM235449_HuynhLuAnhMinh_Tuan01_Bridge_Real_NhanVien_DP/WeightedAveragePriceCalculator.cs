using System;

namespace NongDuocAnGiang.DesignPatterns.Bridge
{
    public class WeightedAveragePriceCalculator : IPriceCalculationStrategy
    {
        public decimal CalculateBaseExportPrice(string productCode, int quantity)
        {
            Console.WriteLine($"   [Database] Đang tính tổng giá trị và tổng số lượng tồn kho của mã {productCode}...");
            Console.WriteLine($"   [Tính toán] Áp dụng phương pháp BÌNH QUÂN GIA QUYỀN.");

            // Giả lập logic tính giá bình quân
            decimal unitPrice = 125500m;
            return unitPrice * quantity;
        }
    }
}