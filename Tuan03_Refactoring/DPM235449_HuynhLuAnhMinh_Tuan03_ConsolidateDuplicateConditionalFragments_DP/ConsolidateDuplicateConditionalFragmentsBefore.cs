using System;

namespace AnGiangPesticideRefactoring
{
    public class ConsolidateDuplicateConditionalFragmentsBefore
    {
        public void ProcessOrder(bool isVipCustomer, double orderAmount)
        {
            double finalPrice;
            if (isVipCustomer)
            {
                finalPrice = orderAmount * 0.85; // Giảm 15% cho khách VIP
                SaveOrderToDatabase(finalPrice); // Dòng code bị lặp lại ở cả 2 nhánh
            }
            else
            {
                finalPrice = orderAmount * 0.95; // Giảm 5% cho khách thường
                SaveOrderToDatabase(finalPrice); // Dòng code bị lặp lại ở cả 2 nhánh
            }
        }

        private void SaveOrderToDatabase(double price)
        {
            Console.WriteLine($"[Before] Da luu hoa don voi tong tien: {price:N0} VND vao database.");
        }
    }
}