using System;

namespace NongDuocAnGiang.DesignPatterns.Flyweight
{
    public class TransactionUniqueState
    {
        public string BatchId { get; set; }
        public DateTime TransactionDate { get; set; }
        public int Quantity { get; set; }
        public string TransactionType { get; set; } // "Nhập" hoặc "Xuất"

        public TransactionUniqueState(string batchId, DateTime date, int quantity, string type)
        {
            BatchId = batchId;
            TransactionDate = date;
            Quantity = quantity;
            TransactionType = type;
        }
    }
}