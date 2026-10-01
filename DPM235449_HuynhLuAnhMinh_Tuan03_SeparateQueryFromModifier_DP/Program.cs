using System;

namespace AnGiangPesticideRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHAY THU NGHIEM: SEPARATE QUERY FROM MODIFIER ===");

            // 1. Test Before
            SeparateQueryFromModifierBefore before = new SeparateQueryFromModifierBefore();
            string resBefore = before.CheckAndDeductStock(2);
            Console.WriteLine($"1. Ket qua Before: {resBefore}");

            // 2. Test After
            SeparateQueryFromModifierAfter after = new SeparateQueryFromModifierAfter();
            bool isAvailable = after.CheckStockAvailability(2); // Chỉ gọi Query
            Console.WriteLine($"2. Ket qua After (Kiem tra kho co du?): {isAvailable}");
            if (isAvailable)
            {
                after.DeductStock(2); // Gọi Modifier riêng biệt
            }

            // 3. Test Real (Nghiệp vụ kiểm soát công nợ đại lý nông dược An Giang)
            // Đại lý có công nợ 3,500,000 VND nhưng hạn mức tín dụng chỉ là 3,000,000 VND
            SeparateQueryFromModifierReal realAgency = new SeparateQueryFromModifierReal("Dai ly Vat tu Bay Long", 3500000, 3000000);

            Console.WriteLine("\n3. Test Real:");
            // Sử dụng Query để kiểm tra trước
            bool isOverdue = realAgency.HasExceededCreditLimit();
            Console.WriteLine($"-> Dai ly co vuot han muc cong no khong?: {isOverdue}");

            // Nếu vượt quá, thực hiện Modifier để khóa tài khoản
            if (isOverdue)
            {
                realAgency.LockAgencyAccountDueToDebt();
            }

            Console.ReadKey();
        }
    }
}