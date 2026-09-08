namespace Bai2_FactoryMethod
{
    public class ConsultingServiceCreator : ServiceCreator
    {
        public override AdditionalService CreateService() => new AgriculturalConsultingService();
    }
}