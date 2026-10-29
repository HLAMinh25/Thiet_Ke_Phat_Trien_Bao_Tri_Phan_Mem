using System;

namespace Bai1_AbstractFactory
{
    public class FifoValuation : IValuationStrategy
    {
        public decimal CalculateExportPrice(string productId, int quantity)
        {
            Console.WriteLine("[Báo cáo] Tính giá xuất kho theo phương pháp FIFO.");
            return 150000m * quantity;
        }
    }
}