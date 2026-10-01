using System;

namespace AnGiangPesticideRefactoring
{
    public class ExtractVariableReal
    {
        // Nghiệp vụ thực tế: Tính hóa đơn xuất kho lô thuốc trừ sâu cho đại lý cấp 1
        public double CalculateBatchOrderTotal(double basePrice, int quantity, double extraServiceFee, bool isVipAgency)
        {
            // 1. Trích xuất biến: Tính tổng tiền hàng cơ bản của lô thuốc
            double grossMerchandiseValue = basePrice * quantity;

            // 2. Trích xuất biến: Xác định tỷ lệ chiết khấu ưu đãi theo diện đại lý và giá trị đơn hàng
            double loyaltyDiscountRate = (isVipAgency && grossMerchandiseValue >= 1000000) ? 0.12 : 0.05;

            // 3. Trích xuất biến: Số tiền được giảm giá thực tế trên tổng đơn hàng
            double totalDiscountValue = grossMerchandiseValue * loyaltyDiscountRate;

            // 4. Trích xuất biến: Thuế VAT áp dụng cho hóa đơn vật tư nông nghiệp (ví dụ 5%)
            double vatTaxAmount = (grossMerchandiseValue - totalDiscountValue) * 0.05;

            // Tổng hợp các biến đã được trích xuất để trả về kết quả cuối cùng rõ ràng, minh bạch
            double finalOrderAmount = (grossMerchandiseValue - totalDiscountValue) + vatTaxAmount + extraServiceFee;

            return finalOrderAmount;
        }
    }
}