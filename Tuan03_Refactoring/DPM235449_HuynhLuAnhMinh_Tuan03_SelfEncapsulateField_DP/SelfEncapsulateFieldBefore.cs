using System;

namespace AnGiangPesticideRefactoring
{
    public class SelfEncapsulateFieldBefore
    {
        private double price; // Truy cập trực tiếp biến nội bộ

        public SelfEncapsulateFieldBefore(double initialPrice)
        {
            price = initialPrice;
        }

        // Tính toán dựa trên việc truy xuất trực tiếp trường price
        public void RaisePrice(double percentage)
        {
            price = price + (price * percentage / 100);
            Console.WriteLine($"[Before] Gia ban truc tiep: {price:N0} VND");
        }

        public double GetPrice()
        {
            return price;
        }
    }
}