using System;

namespace AnGiangPesticideRefactoring
{
    public class RenameMethodAfter
    {
        // Áp dụng Rename Method: Đổi tên phương thức rõ nghĩa, bộc lộ ý định
        public double CalculateTotalMerchandiseValue(double unitPrice, int quantity)
        {
            return unitPrice * quantity;
        }
    }
}