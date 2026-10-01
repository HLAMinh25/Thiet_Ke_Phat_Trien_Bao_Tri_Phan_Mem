using System;

namespace AnGiangPesticideRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHAY THU NGHIEM: PARAMETERIZE METHOD ===");

            // 1. Test Before
            ParameterizeMethodBefore before = new ParameterizeMethodBefore();
            Console.WriteLine($"1. Ket qua Before (Giam 10%): {before.TenPercentDiscount(200000):N0} VND");
            Console.WriteLine($"   Ket qua Before (Giam 15%): {before.FifteenPercentDiscount(200000):N0} VND");

            // 2. Test After
            ParameterizeMethodAfter after = new ParameterizeMethodAfter();
            Console.WriteLine($"2. Ket qua After (Tham so hoa giam 12%): {after.CalculateDiscountedAmount(200000, 0.12):N0} VND");

            // 3. Test Real (Nghiệp vụ tính phí vận chuyển linh hoạt theo vùng tại An Giang)
            // Lô hàng nặng 50 kg xuất kho giao về đại lý
            ParameterizeMethodReal realOrder = new ParameterizeMethodReal("HD-LOG-2026", 50.0);

            Console.WriteLine("\n3. Test Real (Tinh phi van chuyen theo tham so khu vực):");
            // Giao về Long Xuyên với cước phí 5,000 VND/kg
            realOrder.PrintShippingSummary("Thanh pho Long Xuyen", 5000);

            Console.WriteLine();
            // Giao về vùng xa hơn với cước phí 9,000 VND/kg sử dụng chung phương thức Parameterize Method
            realOrder.PrintShippingSummary("Huyen Tri Ton", 9000);

            Console.ReadKey();
        }
    }
}