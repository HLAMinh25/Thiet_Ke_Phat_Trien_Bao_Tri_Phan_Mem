namespace Bai1_AbstractFactory
{
    public class WholesaleConfigFactory : ISalesConfigFactory
    {
        public IValuationStrategy CreateValuationStrategy() => new FifoValuation();
        public IBatchDispatchStrategy CreateBatchDispatchStrategy() => new ManualDispatch();
    }
}