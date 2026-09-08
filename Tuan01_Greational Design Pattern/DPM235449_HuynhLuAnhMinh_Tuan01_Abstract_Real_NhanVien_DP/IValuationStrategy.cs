namespace Bai1_AbstractFactory
{
    public interface IValuationStrategy
    {
        decimal CalculateExportPrice(string productId, int quantity);
    }
}