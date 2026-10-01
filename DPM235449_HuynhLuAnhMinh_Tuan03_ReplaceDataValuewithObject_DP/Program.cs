using System;

namespace AnGiangPesticideRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHAY THU NGHIEM: REPLACE DATA VALUE WITH OBJECT ===");

            // 1. Test Before
            ReplaceDataValueWithObjectBefore before = new ReplaceDataValueWithObjectBefore("HD-01", "0909123456");
            Console.WriteLine("1. Ket qua Before:");
            before.PrintOrderInfo();

            // 2. Test After
            PhoneNumberObject phoneObj = new PhoneNumberObject("0909123456");
            ReplaceDataValueWithObjectAfter after = new ReplaceDataValueWithObjectAfter("HD-01", phoneObj);
            Console.WriteLine("\n2. Ket qua After:");
            after.PrintOrderInfo();

            // 3. Test Real (Nghiệp vụ quản lý khu vực đại lý nông dược An Giang)
            // Thử nghiệm với mã vùng "LX" (Long Xuyên)
            ReplaceDataValueWithObjectReal realAgency = new ReplaceDataValueWithObjectReal("AG-LX-88", "Dai ly Vat tu Nong nghiep Bay Long", "LX");
            Console.WriteLine("\n3. Ket qua Real:");
            realAgency.PrintAgencyProfile();

            Console.ReadKey();
        }
    }
}