using System;

namespace AnGiangPesticideRefactoring
{
    // Lớp chứa dữ liệu đặc thù về lô thuốc nông dược (ngày hết hạn, số lượng tồn kho theo lô)
    public class InventoryBatchReal
    {
        public string BatchId { get; set; }
        public int DaysToExpiry { get; set; } // Số ngày còn lại trước khi hết hạn
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }

        public InventoryBatchReal(string batchId, int daysToExpiry, double unitPrice, int quantity)
        {
            BatchId = batchId;
            DaysToExpiry = daysToExpiry;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }

        // Áp dụng Move Method: Đưa logic tính toán giá trị chiết khấu xả kho lô cận date về đúng lớp InventoryBatchReal quản lý nó
        public double CalculateBatchClearingPrice()
        {
            double standardValue = UnitPrice * Quantity;

            // Nếu lô thuốc cận date (dưới 30 ngày), tự động áp dụng tỷ lệ xả kho giảm 30%
            if (DaysToExpiry <= 30)
            {
                return standardValue * 0.70; // Giảm 30%
            }
            return standardValue;
        }
    }

    // Lớp quản lý hóa đơn (trước đây ôm đùm logic kiểm tra ngày tháng của lô hàng)
    public class MoveMethodReal
    {
        public string InvoiceNumber { get; set; }
        public InventoryBatchReal Batch { get; set; }

        public MoveMethodReal(string invoiceNumber, InventoryBatchReal batch)
        {
            InvoiceNumber = invoiceNumber;
            Batch = batch;
        }

        // Thay vì xử lý logic phức tạp ngoài hóa đơn, ta ủy quyền tính toán trực tiếp cho đối tượng Batch (Move Method pattern)
        public double GetFinalBatchAmount()
        {
            return Batch.CalculateBatchClearingPrice();
        }
    }
}