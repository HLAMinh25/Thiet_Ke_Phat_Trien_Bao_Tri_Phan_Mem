using System;

namespace AnGiangPesticideRefactoring
{
    public class DecomposeConditionalReal
    {
        // Nghiệp vụ thực tế: Tính toán hệ số chiết khấu mùa vụ phòng trừ dịch bệnh cho đại lý nông dược
        public double CalculatePesticideDiscountRate(int orderedQuantity, double orderTotalValue, bool isTierOneAgency)
        {
            // Áp dụng Decompose Conditional: Phân rã biểu thức điều kiện phức tạp thành các phương thức rõ ràng
            if (IsPeakPestControlSeasonOrder(orderedQuantity, orderTotalValue))
            {
                return GetPeakSeasonDiscount(isTierOneAgency);
            }
            else
            {
                return GetStandardOffSeasonDiscount();
            }
        }

        // Tách điều kiện: Kiểm tra xem có phải đơn hàng đặt trong mùa cao điểm phòng trừ sâu bệnh không
        private bool IsPeakPestControlSeasonOrder(int quantity, double totalValue)
        {
            // Mùa cao điểm: Số lượng mua trên 50 đơn vị hoặc giá trị đơn hàng vượt mức 1,5 triệu đồng
            return quantity > 50 || totalValue >= 1500000;
        }

        // Tách hành động nhánh 1: Tính chiết khấu mùa cao điểm (Đại lý cấp 1 ưu đãi 15%, đại lý thường 10%)
        private double GetPeakSeasonDiscount(bool isTierOne)
        {
            return isTierOne ? 0.15 : 0.10;
        }

        // Tách hành động nhánh 2: Tính chiết khấu mùa bình thường (mặc định 3%)
        private double GetStandardOffSeasonDiscount()
        {
            return 0.03;
        }
    }
}