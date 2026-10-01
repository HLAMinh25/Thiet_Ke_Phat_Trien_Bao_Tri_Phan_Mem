using System;

namespace AnGiangPesticideRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHAY THU NGHIEM: EXTRACT VARIABLE ===");

            // 1. Test Before
            ExtractVariableBefore before = new ExtractVariableBefore();
            double resultBefore = before.CalculateFinalPrice(120000, 6, 0.0, 30000);
            Console.WriteLine($"1. Ket qua Before: {resultBefore:N0} VND");

            // 2. Test After
            ExtractVariableAfter after = new ExtractVariableAfter();
            double resultAfter = after.CalculateFinalPrice(120000, 6, 0.0, 30000);
            Console.WriteLine($"2. Ket qua After: {resultAfter:N0} VND");

            // 3. Test Real (Nghiệp vụ Nông dược An Giang)
            ExtractVariableReal real = new ExtractVariableReal();
            double resultReal = real.CalculateBatchOrderTotal(150000, 8, 25000, true);
            Console.WriteLine($"3. Ket qua Real (Xuat kho lo nong duoc): {resultReal:N0} VND");

            Console.ReadKey();
        }
    }
}