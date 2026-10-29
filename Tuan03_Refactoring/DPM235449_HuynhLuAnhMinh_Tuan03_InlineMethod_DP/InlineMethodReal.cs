using System;

namespace AnGiangPesticideRefactoring
{
    public class InlineMethodReal
    {
        private int remainingDaysToExpiry = 15; // Số ngày còn lại trước khi lô thuốc trừ sâu hết hạn

        // Nghiệp vụ thực tế: Kiểm tra xem lô hàng có phải là hàng cận date cần áp dụng chính sách giảm giá xả kho hay không
        public string CheckBatchPolicyStatus()
        {
            // Thay vì gọi một hàm CheckExpiryAlert() quá ngắn và rườm rà, ta tiến hành "Inline Method" vào đây trực tiếp
            if (remainingDaysToExpiry <= 30)
            {
                return "Canh bao: Lo hang can date (<= 30 ngay), yeu cau ap dung gia xa kho!";
            }
            return "Lo hang binh thuong, du han su dung.";
        }
    }
}