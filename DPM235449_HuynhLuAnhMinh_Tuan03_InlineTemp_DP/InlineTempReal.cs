using System;

namespace AnGiangPesticideRefactoring
{
    public class InlineTempReal
    {
        // Nghiệp vụ thực tế: Kiểm tra điều kiện miễn phí vận chuyển cho đại lý mua lô hàng lớn
        public bool CheckFreeShippingCondition(double batchUnitPrice, int orderedQuantity, double seasonalPromotionBonus)
        {
            // Ban đầu code cũ có thể dùng biến tạm: double totalValue = (batchUnitPrice * orderedQuantity) + seasonalPromotionBonus;
            // Áp dụng Inline Temp để đưa thẳng biểu thức tính toán vào điều kiện kiểm tra ngưỡng miễn phí (ví dụ: 2,000,000 VND)

            return ((batchUnitPrice * orderedQuantity) + seasonalPromotionBonus) >= 2000000;
        }
    }
}