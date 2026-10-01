using System;

namespace Bai1_AbstractFactory
{
    public class SalesOrderProcessor
    {
        private readonly IValuationStrategy _valuation;
        private readonly IBatchDispatchStrategy _dispatch;

        public SalesOrderProcessor(ISalesConfigFactory factory)
        {
            _valuation = factory.CreateValuationStrategy();
            _dispatch = factory.CreateBatchDispatchStrategy();
        }

        public void ProcessOrder(string productId, int quantity)
        {
            _dispatch.SelectBatch(productId, quantity);
            decimal total = _valuation.CalculateExportPrice(productId, quantity);
            Console.WriteLine($"[Thành tiền] {total:N0} VNĐ\n");
        }
    }
}