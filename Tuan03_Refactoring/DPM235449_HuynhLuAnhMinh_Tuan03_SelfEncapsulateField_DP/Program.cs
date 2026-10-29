using System;

namespace AnGiangPesticideRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHAY THU NGHIEM: SELF ENCAPSULATE FIELD ===");

            // 1. Test Before
            SelfEncapsulateFieldBefore before = new SelfEncapsulateFieldBefore(100000);
            before.RaisePrice(10);

            // 2. Test After
            SelfEncapsulateFieldAfter after = new SelfEncapsulateFieldAfter(100000);
            after.RaisePrice(10);

            // 3. Test Real (Nghiệp vụ điều chỉnh đơn giá thuốc bảo vệ thực vật An Giang)
            var realProduct = new SelfEncapsulateFieldReal("Thuoc Tru Sau Anvil 5SC", 120000);

            Console.WriteLine("\n3. Ket qua Real:");
            // Tính giá trị đơn hàng xuất kho với số lượng 50 và chiết khấu mùa vụ 5%
            double batchTotal = realProduct.CalculateBatchValueWithDiscount(50, 0.05);
            Console.WriteLine($"-> Gia tri lo hang tam tinh (chua dieu chinh gia): {batchTotal:N0} VND");

            // Tiến hành cập nhật giá thị trường mới thông qua cơ chế Self Encapsulate Field
            realProduct.ApplyNewMarketPrice(130000);

            Console.ReadKey();
        }
    }
}