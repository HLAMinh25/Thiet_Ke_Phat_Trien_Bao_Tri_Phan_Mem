namespace Bai2_FactoryMethod
{
    public class ShippingServiceCreator : ServiceCreator
    {
        public override AdditionalService CreateService() => new ShippingService();
    }
}