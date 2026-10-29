using System;

namespace Bai1_AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== BÀI 1: ABSTRACT FACTORY - CẤU HÌNH BÁN HÀNG ===\n");

            Console.WriteLine("--- CHẾ ĐỘ BÁN LẺ ---");
            SalesOrderProcessor retailProcessor = new SalesOrderProcessor(new RetailSalesConfigFactory());
            retailProcessor.ProcessOrder("ND-001", 10);

            Console.WriteLine("--- CHẾ ĐỘ BÁN SỈ ---");
            SalesOrderProcessor wholesaleProcessor = new SalesOrderProcessor(new WholesaleConfigFactory());
            wholesaleProcessor.ProcessOrder("ND-001", 500);

            Console.ReadLine();
        }
    }
}