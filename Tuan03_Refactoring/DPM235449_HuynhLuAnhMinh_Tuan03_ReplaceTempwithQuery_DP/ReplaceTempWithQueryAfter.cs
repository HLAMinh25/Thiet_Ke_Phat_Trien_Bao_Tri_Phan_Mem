using System;

namespace AnGiangPesticideRefactoring
{
    public class ReplaceTempWithQueryAfter
    {
        private double unitPrice;
        private int quantity;

        public ReplaceTempWithQueryAfter(double unitPrice, int quantity)
        {
            this.unitPrice = unitPrice;
            this.quantity = quantity;
        }

        // Thay vì dùng biến tạm, ta gọi các query method riêng biệt
        public double CalculateTotal()
        {
            return BasePrice() - (BasePrice() * DiscountFactor());
        }

        // Phương thức truy vấn 1: Tính giá cơ bản
        private double BasePrice()
        {
            return unitPrice * quantity;
        }

        // Phương thức truy vấn 2: Lấy hệ số chiết khấu
        private double DiscountFactor()
        {
            return BasePrice() > 500000 ? 0.10 : 0.05;
        }
    }
}