using System;

namespace AnGiangPesticideRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHAY THU NGHIEM: CONSOLIDATE DUPLICATE CONDITIONAL FRAGMENTS ===");

            // 1. Test Before
            ConsolidateDuplicateConditionalFragmentsBefore before = new ConsolidateDuplicateConditionalFragmentsBefore();
            Console.WriteLine("1. Test Before:");
            before.ProcessOrder(true, 500000);

            // 2. Test After
            ConsolidateDuplicateConditionalFragmentsAfter after = new ConsolidateDuplicateConditionalFragmentsAfter();
            Console.WriteLine("\n2. Test After:");
            after.ProcessOrder(true, 500000);

            // 3. Test Real (Nghiệp vụ xuất kho nông dược An Giang)
            ConsolidateDuplicateConditionalFragmentsReal real = new ConsolidateDuplicateConditionalFragmentsReal();
            Console.WriteLine("\n3. Test Real (Xuat kho cho dai ly si):");
            real.ExportBatchProduct("LO-BVTV-BENLATE-02", true, 20, 150000);

            Console.ReadKey();
        }
    }
}