using System;

namespace AnGiangPesticideRefactoring
{
    public class AddParameterBefore
    {
        // Phương thức cũ thiếu tham số mùa vụ hoặc mã ưu đãi
        public double CalculateOrderTotal(double unitPrice, int quantity)
        {
            double subTotal = unitPrice * quantity;
            return subTotal; // Thiếu khả năng áp dụng chiết khấu theo chương trình khuyến mãi
        }
    }
}