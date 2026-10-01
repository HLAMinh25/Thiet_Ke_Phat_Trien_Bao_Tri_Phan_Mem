using System;

namespace AnGiangPesticideRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHAY THU NGHIEM: MOVE FIELD ===");

            // 1. Test Before
            var accBefore = new AccountBefore(0.10, DateTime.Now.AddYears(1));
            MoveFieldBefore moveBefore = new MoveFieldBefore("Dai ly Bay Long", accBefore);
            Console.WriteLine($"1. Ket qua Before (Chiet khau): {moveBefore.CalculateCustomerDiscount(500000):N0} VND");

            // 2. Test After
            var accAfter = new AccountAfter(DateTime.Now.AddYears(1));
            MoveFieldAfter moveAfter = new MoveFieldAfter("Dai ly Bay Long", accAfter, 0.10);
            Console.WriteLine($"2. Ket qua After (Chiet khau): {moveAfter.CalculateCustomerDiscount(500000):N0} VND");

            // 3. Test Real (Nghiệp vụ hoa hồng đại lý phân phối nông dược An Giang)
            var config = new SystemConfigReal();
            var agency = new AgencyProfileReal("Dai ly Vat tu Nong nghiep An Giang", "Long Xuyen", 0.08); // Hoa hồng 8%
            MoveFieldReal moveReal = new MoveFieldReal(config, agency);
            Console.WriteLine($"3. Ket qua Real (Hoa hong dai ly nong duoc): {moveReal.GetCommissionPayout(1000000):N0} VND");

            Console.ReadKey();
        }
    }
}