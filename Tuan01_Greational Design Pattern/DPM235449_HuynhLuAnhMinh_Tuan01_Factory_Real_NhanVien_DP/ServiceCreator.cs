using System;

namespace Bai2_FactoryMethod
{
    public abstract class ServiceCreator
    {
        public abstract AdditionalService CreateService();

        public void RenderServiceFee(decimal invoiceAmount)
        {
            var service = CreateService();
            decimal fee = service.CalculateFee(invoiceAmount);
            Console.WriteLine($"[Dịch vụ] {service.ServiceName}");
            Console.WriteLine($"[Phí tính toán] {fee:N0} VNĐ\n");
        }
    }
}