using System;

namespace NongDuocAnGiang.DesignPatterns.Flyweight
{
    public class InventoryFlyweight
    {
        private readonly ProductSharedState _sharedState;

        public InventoryFlyweight(ProductSharedState sharedState)
        {
            this._sharedState = sharedState;
        }

        public void ProcessTransaction(TransactionUniqueState uniqueState)
        {
            Console.WriteLine($"[Ghi nhận {uniqueState.TransactionType}] " +
                              $"Lô: {uniqueState.BatchId} | " +
                              $"Sản phẩm: {_sharedState.ProductName} ({_sharedState.Category}) | " +
                              $"Số lượng: {uniqueState.Quantity} {_sharedState.Unit} | " +
                              $"Ngày: {uniqueState.TransactionDate:dd/MM/yyyy}");
        }
    }
}