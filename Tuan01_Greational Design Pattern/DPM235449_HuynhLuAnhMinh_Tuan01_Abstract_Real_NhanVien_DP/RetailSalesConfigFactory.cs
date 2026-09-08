namespace Bai1_AbstractFactory
{
    public class RetailSalesConfigFactory : ISalesConfigFactory
    {
        public IValuationStrategy CreateValuationStrategy() => new WeightedAverageValuation();
        public IBatchDispatchStrategy CreateBatchDispatchStrategy() => new AutoExpiryDispatch();
    }
}