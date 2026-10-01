using System;

namespace AnGiangPesticideRefactoring
{
    public class AccountBefore
    {
        // Vấn đề: Trường discountRate nằm ở đây nhưng lại bị lớp Customer truy xuất hoặc phục vụ nhiều hơn
        public double DiscountRate { get; set; }
        public DateTime ExpiryDate { get; set; }

        public AccountBefore(double discountRate, DateTime expiryDate)
        {
            DiscountRate = discountRate;
            ExpiryDate = expiryDate;
        }
    }

    public class MoveFieldBefore
    {
        public string CustomerName { get; set; }
        public AccountBefore Account { get; set; }

        public MoveFieldBefore(string customerName, AccountBefore account)
        {
            CustomerName = customerName;
            Account = account;
        }

        // Phương thức tính toán chiết khấu phải với sang lớp Account để lấy dữ liệu
        public double CalculateCustomerDiscount(double orderAmount)
        {
            return orderAmount * Account.DiscountRate;
        }
    }
}