using System;

namespace AnGiangPesticideRefactoring
{
    public class InlineTempAfter
    {
        // Sau khi loại bỏ biến tạm (Inline Temp), biểu thức được đặt trực tiếp vào câu lệnh trả về
        public bool IsOrderEligibleForDiscount(double unitPrice, int quantity)
        {
            return (unitPrice * quantity) > 500000;
        }
    }
}