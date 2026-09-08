using System;

namespace Bai1_AbstractFactory
{
    public class AutoExpiryDispatch : IBatchDispatchStrategy
    {
        public void SelectBatch(string productId, int quantity)
        {
            Console.WriteLine("[Kho] Tự động chọn lô hàng có HẠN SỬ DỤNG GẦN NHẤT.");
        }
    }
}