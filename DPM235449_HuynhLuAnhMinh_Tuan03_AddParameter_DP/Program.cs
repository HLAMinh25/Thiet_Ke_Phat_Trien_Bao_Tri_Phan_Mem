using System;

namespace AnGiangPesticideRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHAY THU NGHIEM: ADD PARAMETER ===");

            // 1. Test Before
            AddParameterBefore before = new AddParameterBefore();
            double totalBefore = before.CalculateOrderTotal(120000, 10);
            Console.WriteLine($"1. Ket qua Before: {totalBefore:N0} VND");

            // 2. Test After
            AddParameterAfter after = new AddParameterAfter();
            double totalAfter = after.CalculateOrderTotal(120000, 10, true);
            Console.WriteLine($"2. Ket qua After (Co tham so mua vu): {totalAfter:N0} VND");

            // 3. Test Real (Nghiệp vụ xuất kho kèm phụ phí vận chuyển và voucher của An Giang)
            AddParameterReal realOrder = new AddParameterReal("HD-AG-2026-88", "Thuoc Tru Sau Anvil 5SC");

            Console.WriteLine("\n3. Ket qua Real:");
            // Tính tổng tiền cho 20 đơn vị thuốc, đơn giá 150,000 VND, phí vận chuyển vùng 35,000 VND, voucher giảm 50,000 VND
            double finalAmount = realOrder.CalculateFinalInvoiceAmount(150000, 20, 35000, 50000);
            Console.WriteLine($"-> TONG THANH TOAN THUC TE: {finalAmount:N0} VND");

            Console.ReadKey();
        }
    }
}