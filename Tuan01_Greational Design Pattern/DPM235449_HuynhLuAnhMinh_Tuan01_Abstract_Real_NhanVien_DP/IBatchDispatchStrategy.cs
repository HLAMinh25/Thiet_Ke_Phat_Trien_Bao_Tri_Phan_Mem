namespace Bai1_AbstractFactory
{
    public interface IBatchDispatchStrategy
    {
        void SelectBatch(string productId, int quantity);
    }
}