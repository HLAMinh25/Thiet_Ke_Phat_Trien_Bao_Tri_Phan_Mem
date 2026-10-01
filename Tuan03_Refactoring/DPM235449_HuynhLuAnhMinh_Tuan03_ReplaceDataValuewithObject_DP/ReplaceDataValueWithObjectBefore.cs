using System;

namespace AnGiangPesticideRefactoring
{
    public class ReplaceDataValueWithObjectBefore
    {
        public string OrderId { get; set; }
        public string CustomerPhone { get; set; } // Sử dụng kiểu chuỗi nguyên thủy (Data Value)

        public ReplaceDataValueWithObjectBefore(string orderId, string customerPhone)
        {
            OrderId = orderId;
            CustomerPhone = customerPhone;
        }

        public void PrintOrderInfo()
        {
            Console.WriteLine($"[Before] Don hang: {OrderId} | SDT khach hang: {CustomerPhone}");
        }
    }
}