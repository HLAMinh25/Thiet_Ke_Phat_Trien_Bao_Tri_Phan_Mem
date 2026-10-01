using System;

namespace AnGiangPesticideRefactoring
{
    public class ConsolidateDuplicateConditionalFragmentsAfter
    {
        public void ProcessOrder(bool isVipCustomer, double orderAmount)
        {
            double finalPrice;
            if (isVipCustomer)
            {
                finalPrice = orderAmount * 0.85;
            }
            else
            {
                finalPrice = orderAmount * 0.95;
            }

            // Đoạn code giống nhau đã được chuyển ra bên ngoài cấu trúc điều kiện
            SaveOrderToDatabase(finalPrice);
        }

        private void SaveOrderToDatabase(double price)
        {
            Console.WriteLine($"[After] Da luu hoa don voi tong tien: {price:N0} VND vao database.");
        }
    }
}