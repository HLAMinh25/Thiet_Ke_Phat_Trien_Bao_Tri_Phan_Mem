using System;

namespace NongDuocAnGiang.DesignPatterns.Facade
{
    public class InventorySubsystem
    {
        public string GetInventoryData(DateTime fromDate, DateTime toDate)
        {
            return $"[Kho] Dữ liệu tồn kho lô hàng từ {fromDate:dd/MM/yyyy} đến {toDate:dd/MM/yyyy}";
        }

        public string CheckLowStockItems()
        {
            return "[Kho] Cảnh báo: Thuốc trừ sâu sinh học A1 sắp hết hạn/hết hàng";
        }
    }
}