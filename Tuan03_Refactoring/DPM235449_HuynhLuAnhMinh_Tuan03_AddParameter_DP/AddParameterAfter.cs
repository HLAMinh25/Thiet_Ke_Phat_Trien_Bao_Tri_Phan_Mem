using System;

namespace AnGiangPesticideRefactoring
{
    public class AddParameterAfter
    {
        // Áp dụng Add Parameter: Bổ sung thêm tham số `isSpecialSeason` để tính toán chiết khấu linh hoạt hơn
        public double CalculateOrderTotal(double unitPrice, int quantity, bool isSpecialSeason)
        {
            double subTotal = unitPrice * quantity;

            if (isSpecialSeason)
            {
                return subTotal * 0.90; // Giảm 10% trong mùa đặc biệt
            }

            return subTotal;
        }
    }
}