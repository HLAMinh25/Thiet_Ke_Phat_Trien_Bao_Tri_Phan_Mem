using System;

namespace Bai1_AbstractFactory
{
    public class WeightedAverageValuation : IValuationStrategy
    {
        public decimal CalculateExportPrice(string productId, int quantity)
        {
            Console.WriteLine("[Báo cáo] Tính giá xuất kho theo phương pháp Bình quân gia quyền.");
            return 145000m * quantity;
        }
    }
}