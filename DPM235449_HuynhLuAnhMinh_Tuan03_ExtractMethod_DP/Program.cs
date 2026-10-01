using System;
using System.Collections.Generic;

namespace AnGiangPesticideRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== 1. CHAY THU CODE BEFORE ===");
            ExtractMethodBefore before = new ExtractMethodBefore();
            before.PrintOwing();

            Console.WriteLine("\n=== 2. CHAY THU CODE AFTER ===");
            ExtractMethodAfter after = new ExtractMethodAfter();
            after.PrintOwing();

            Console.WriteLine("\n=== 3. CHAY THU CODE REAL (NGHIEP VU NONG DUOC AN GIANG) ===");
            ExtractMethodReal realManager = new ExtractMethodReal();

            List<PesticideItem> purchasedItems = new List<PesticideItem>
            {
                new PesticideItem { ProductName = "Thuoc tru sau Benlate C (Lo A)", UnitPrice = 120000, Quantity = 5 },
                new PesticideItem { ProductName = "Phan bon la An Giang Gold (Lo B)", UnitPrice = 85000, Quantity = 10 }
            };

            // Gọi hàm tính hóa đơn gồm phí vận chuyển (30k), dịch vụ phụ (15k), giảm giá VIP (hoặc chiết khấu)
            realManager.ProcessAndPrintOrder(
                customerName: "Dai ly Vat tu Nong nghiep Bay Long",
                items: purchasedItems,
                shippingFee: 30000,
                additionalServiceFee: 15000,
                discountPercent: 0,
                isVip: true
            );

            Console.ReadKey();
        }
    }
}