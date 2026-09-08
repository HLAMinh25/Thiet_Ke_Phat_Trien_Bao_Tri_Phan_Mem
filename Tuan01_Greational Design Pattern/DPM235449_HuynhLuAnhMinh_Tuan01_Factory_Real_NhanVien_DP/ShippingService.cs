namespace Bai2_FactoryMethod
{
    public class ShippingService : AdditionalService
    {
        public override string ServiceName => "Chi phí vận chuyển Nông dược";

        public override decimal CalculateFee(decimal baseAmount)
        {
            // Miễn phí vận chuyển cho đơn hàng lớn hơn 10 triệu
            return baseAmount > 10000000m ? 0m : 250000m;
        }
    }
}