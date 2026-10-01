using System;

namespace AnGiangPesticideRefactoring
{
    public class AccountAfter
    {
        public DateTime ExpiryDate { get; set; }

        public AccountAfter(DateTime expiryDate)
        {
            ExpiryDate = expiryDate;
        }
    }

    public class MoveFieldAfter
    {
        public string CustomerName { get; set; }
        public AccountAfter Account { get; set; }

        // Trường DiscountRate đã được di chuyển (Move Field) đến đúng lớp Customer này
        public double DiscountRate { get; set; }

        public MoveFieldAfter(string customerName, AccountAfter account, double discountRate)
        {
            CustomerName = customerName;
            Account = account;
            DiscountRate = discountRate;
        }

        // Phương thức tính toán giờ đây truy cập trực tiếp trường dữ liệu nằm cùng lớp
        public double CalculateCustomerDiscount(double orderAmount)
        {
            return orderAmount * DiscountRate;
        }
    }
}