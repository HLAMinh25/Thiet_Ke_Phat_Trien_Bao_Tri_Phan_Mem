using System;

namespace Bai2_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== BÀI 2: FACTORY METHOD - DỊCH VỤ PHÁT SINH ===\n");

            decimal invoiceValue = 5000000m; // Hóa đơn 5 triệu

            ServiceCreator shippingCreator = new ShippingServiceCreator();
            shippingCreator.RenderServiceFee(invoiceValue);

            ServiceCreator consultingCreator = new ConsultingServiceCreator();
            consultingCreator.RenderServiceFee(invoiceValue);

            Console.ReadLine();
        }
    }
}