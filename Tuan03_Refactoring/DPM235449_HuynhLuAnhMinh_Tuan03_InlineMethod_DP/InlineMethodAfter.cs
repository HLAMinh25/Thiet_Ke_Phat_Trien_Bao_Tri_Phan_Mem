using System;

namespace AnGiangPesticideRefactoring
{
    public class InlineMethodAfter
    {
        private int numberOfLateDeliveries = 6;

        // Sau khi Inline Method: Gộp thẳng logic kiểm tra vào bên trong hàm chính
        public int GetDeliveryRating()
        {
            return numberOfLateDeliveries > 5 ? 2 : 1;
        }
    }
}