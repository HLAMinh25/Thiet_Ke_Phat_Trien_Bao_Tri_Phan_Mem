using System;
using System.Collections.Generic;

namespace AnGiangPesticideRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHAY THU NGHIEM: REMOVE CONTROL FLAG ===");

            List<string> sampleProducts = new List<string> { "Benlate C", "Anvil 5SC", "Tilt Super", "Amistar Top" };

            // 1. Test Before
            RemoveControlFlagBefore before = new RemoveControlFlagBefore();
            Console.WriteLine("1. Test Before:");
            before.SearchProductInStock(sampleProducts, "Tilt Super");

            // 2. Test After
            RemoveControlFlagAfter after = new RemoveControlFlagAfter();
            Console.WriteLine("\n2. Test After:");
            after.SearchProductInStock(sampleProducts, "Tilt Super");

            // 3. Test Real (Nghiệp vụ kiểm tra lô thuốc hết hạn tại kho An Giang)
            RemoveControlFlagReal real = new RemoveControlFlagReal();
            List<PesticideBatchInfo> batchList = new List<PesticideBatchInfo>
            {
                new PesticideBatchInfo("LO-01", 45),
                new PesticideBatchInfo("LO-02", -2), // Lô đã hết hạn
                new PesticideBatchInfo("LO-03", 120)
            };

            Console.WriteLine("\n3. Test Real (Kiem tra lo hang ton kho):");
            real.InspectExpiredBatches(batchList);

            Console.ReadKey();
        }
    }
}