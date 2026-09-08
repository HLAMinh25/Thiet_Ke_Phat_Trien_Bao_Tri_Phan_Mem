namespace Bai2_FactoryMethod
{
    public abstract class AdditionalService
    {
        public abstract string ServiceName { get; }
        public abstract decimal CalculateFee(decimal baseAmount);
    }
}