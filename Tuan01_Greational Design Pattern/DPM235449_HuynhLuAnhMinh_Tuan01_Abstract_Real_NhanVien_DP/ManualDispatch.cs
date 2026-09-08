using System;

namespace Bai1_AbstractFactory
{
    public class ManualDispatch : IBatchDispatchStrategy
    {
        public void SelectBatch(string productId, int quantity)
        {
            Console.WriteLine("[Kho] Xuất kho theo LÔ CHỈ ĐỊNH của thủ kho.");
        }
    }
}