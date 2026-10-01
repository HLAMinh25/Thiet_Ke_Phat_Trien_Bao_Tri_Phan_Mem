namespace Bai2_FactoryMethod
{
    public class AgriculturalConsultingService : AdditionalService
    {
        public override string ServiceName => "Dịch vụ phụ (Tư vấn kỹ thuật phun thuốc)";

        public override decimal CalculateFee(decimal baseAmount)
        {
            return 100000m;
        }
    }
}