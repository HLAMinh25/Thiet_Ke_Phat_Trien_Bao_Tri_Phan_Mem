using System;

namespace AnGiangPesticideRefactoring
{
    public class ExtractVariableBefore
    {
        // Tính tổng tiền thanh toán của hóa đơn với biểu thức phức tạp khó đọc
        public double CalculateFinalPrice(double unitPrice, int quantity, double discountRate, double shippingFee)
        {
            // Biểu thức gộp quá nhiều thành phần: tiền gốc, trừ chiết khấu bậc thang theo số lượng, cộng phí vận chuyển
            return (unitPrice * quantity) - ((unitPrice * quantity > 500000 ? 0.15 : 0.05) * (unitPrice * quantity)) + shippingFee;
        }
    }
}