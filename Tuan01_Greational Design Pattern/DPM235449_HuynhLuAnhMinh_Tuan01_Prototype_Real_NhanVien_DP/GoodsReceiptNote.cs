using System;

namespace Bai4_Prototype
{
    public class GoodsReceiptNote
    {
        public string ProductName { get; set; }
        public string Supplier { get; set; }
        public decimal ImportPrice { get; set; }
        public BatchInfo BatchDetail { get; set; }

        public GoodsReceiptNote(string productName, string supplier, decimal importPrice, BatchInfo batchDetail)
        {
            ProductName = productName;
            Supplier = supplier;
            ImportPrice = importPrice;
            BatchDetail = batchDetail;
        }

        // Deep Copy: Tạo bản sao hoàn toàn độc lập thông tin Lô
        public GoodsReceiptNote DeepCopy()
        {
            GoodsReceiptNote clone = (GoodsReceiptNote)this.MemberwiseClone();
            clone.BatchDetail = new BatchInfo(this.BatchDetail.BatchCode, this.BatchDetail.ExpiryDate);
            return clone;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"[Phiếu Nhập Lô] {ProductName} | NCC: {Supplier} | Số Lô: {BatchDetail.BatchCode} | HSD: {BatchDetail.ExpiryDate:dd/MM/yyyy}");
        }
    }
}