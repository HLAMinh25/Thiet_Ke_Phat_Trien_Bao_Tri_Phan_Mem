using System;

namespace AnGiangPesticideRefactoring
{
    public class ConsolidateDuplicateConditionalFragmentsReal
    {
        public void ExportBatchProduct(string batchCode, bool isWholesaleAgency, int quantity, double baseUnitPrice)
        {
            double totalExportValue;

            // Phân nhánh tính toán đơn giá theo hình thức đại lý
            if (isWholesaleAgency)
            {
                // Đại lý sỉ được tính giá ưu đãi đặc biệt kèm chiết khấu kho
                totalExportValue = (quantity * baseUnitPrice) * 0.80;
            }
            else
            {
                // Đại lý lẻ hoặc khách mua thông thường tính theo giá niêm yết chuẩn
                totalExportValue = quantity * baseUnitPrice;
            }

            // Áp dụng Consolidate Duplicate Conditional Fragments: 
            // Đưa thao tác ghi nhận log xuất kho ra ngoài khối điều kiện vì nhánh nào cũng thực hiện hành động này.
            RecordInventoryLog(batchCode, quantity, totalExportValue);
        }

        private void RecordInventoryLog(string batchCode, int quantity, double totalValue)
        {
            Console.WriteLine($"[Kho An Giang] Ghi nhan xuat kho lo '{batchCode}' | So luong: {quantity} | Gia tri xuat: {totalValue:N0} VND");
        }
    }
}