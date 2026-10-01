using System;

namespace AnGiangPesticideRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHAY THU NGHIEM: EXTRACT CLASS ===");

            // 1. Test Before
            ExtractClassBefore before = new ExtractClassBefore("HD-001", 500000, "Dai ly Bay Long", "0909123456", "Long Xuyen, An Giang");
            Console.WriteLine("1. Ket qua Before:");
            before.PrintOrderDetails();

            // 2. Test After
            AgencyInfo agency = new AgencyInfo("Dai ly Bay Long", "0909123456", "Long Xuyen, An Giang");
            ExtractClassAfter after = new ExtractClassAfter("HD-001", 500000, agency);
            Console.WriteLine("\n2. Ket qua After:");
            after.PrintOrderDetails();

            // 3. Test Real (Nghiệp vụ logistics xuất kho nông dược An Giang)
            ShippingAndLogisticsInfo logistics = new ShippingAndLogisticsInfo("Nguyen Van A", "67B1-888.99", "Kho Tong An Giang", 35000);
            ExtractClassReal real = new ExtractClassReal("HD-ANGL-2026-99", "Thuoc Tru Sau Benlate C", 10, 1200000, logistics);
            Console.WriteLine("\n3. Ket qua Real:");
            real.PrintCompleteInvoice();

            Console.ReadKey();
        }
    }
}