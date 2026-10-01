using System;

namespace AnGiangPesticideRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHAY THU NGHIEM: REMOVE PARAMETER ===");

            // 1. Test Before
            RemoveParameterBefore before = new RemoveParameterBefore();
            double feeBefore = before.CalculateShippingFee(10.0, "Long Xuyen");
            Console.WriteLine($"1. Ket qua Before (Phi van chuyen): {feeBefore:N0} VND");

            // 2. Test After
            RemoveParameterAfter after = new RemoveParameterAfter();
            after.StoreRegion = "Long Xuyen";
            double feeAfter = after.CalculateShippingFee(10.0); // Không cần truyền lại chuỗi vùng miền
            Console.WriteLine($"2. Ket qua After (Phi van chuyen): {feeAfter:N0} VND");

            // 3. Test Real (Nghiệp vụ hóa đơn xuất kho nông dược An Giang)
            var policyConfig = new SeasonalPolicyConfig(); // Đã cấu hình sẵn mức chiết khấu 12%
            RemoveParameterReal realInvoice = new RemoveParameterReal("HD-AG-999", policyConfig);

            Console.WriteLine("\n3. Test Real:");
            // Chỉ cần truyền giá trị tiền hàng gốc `baseSubTotal`, loại bỏ hoàn toàn tham số chiết khấu thừa thãi
            realInvoice.CalculateInvoiceTotalWithDefaultSeasonDiscount(1500000);

            Console.ReadKey();
        }
    }
}