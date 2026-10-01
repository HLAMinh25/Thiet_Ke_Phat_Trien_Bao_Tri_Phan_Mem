using System;

namespace AnGiangPesticideRefactoring
{
    public class InlineMethodBefore
    {
        private int numberOfLateDeliveries = 6; // Số lần giao hàng trễ cho đại lý

        // Phương thức chính gọi đến một hàm phụ quá đơn giản
        public int GetDeliveryRating()
        {
            return MoreThanFiveLateDeliveries() ? 2 : 1;
        }

        // Hàm phụ này quá ngắn, thân hàm còn rõ nghĩa hơn cả tên hàm (Code Smell: Inline Method candidates)
        private bool MoreThanFiveLateDeliveries()
        {
            return numberOfLateDeliveries > 5;
        }
    }
}