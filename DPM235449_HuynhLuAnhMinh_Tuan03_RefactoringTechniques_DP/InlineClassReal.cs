using System;

namespace AnGiangPesticideRefactoring
{
    public class InlineClassReal
    {
        public string BatchCode { get; set; }
        public string ProductName { get; set; }
        public int StockQuantity { get; set; }

        // Trước đây thông tin vị trí kho bãi bị tách thành một lớp riêng (WarehouseLocationInfo) gây rườm rà.
        // Sau khi áp dụng Inline Class, các trường vị trí kho được đưa thẳng vào lớp chính của lô hàng:
        public string WarehouseZone { get; set; }   // Ví dụ: Khu A1
        public string ShelfNumber { get; set; }     // Ví dụ: Kệ số 3

        public InlineClassReal(string batchCode, string productName, int stockQuantity, string warehouseZone, string shelfNumber)
        {
            BatchCode = batchCode;
            ProductName = ProductName;
            StockQuantity = stockQuantity;
            WarehouseZone = warehouseZone;
            ShelfNumber = shelfNumber;
        }

        // Phương thức tra cứu vị trí lưu kho trực tiếp tại lớp quản lý lô hàng sau khi gộp
        public void PrintBatchLocationSummary()
        {
            Console.WriteLine($"[Kho An Giang] Lo: {BatchCode} | San pham: {ProductName} | Ton kho: {StockQuantity} | Vi tri: Khu {WarehouseZone} - Ke {ShelfNumber}");
        }
    }
}