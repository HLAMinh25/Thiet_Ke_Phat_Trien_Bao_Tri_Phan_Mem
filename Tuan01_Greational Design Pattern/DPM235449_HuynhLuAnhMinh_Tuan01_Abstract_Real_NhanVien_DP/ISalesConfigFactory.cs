namespace Bai1_AbstractFactory
{
    public interface ISalesConfigFactory
    {
        IValuationStrategy CreateValuationStrategy();
        IBatchDispatchStrategy CreateBatchDispatchStrategy();
    }
}