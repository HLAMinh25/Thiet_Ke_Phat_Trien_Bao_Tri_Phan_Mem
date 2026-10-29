using System;

namespace AnGiangPesticideRefactoring
{
    // Đối tượng mới thay thế cho giá trị dữ liệu nguyên thủy
    public class PhoneNumberObject
    {
        public string Number { get; }

        public PhoneNumberObject(string number)
        {
            if (string.IsNullOrWhiteSpace(number) || number.Length < 10)
            {
                throw new ArgumentException("So dien thoai khong hop le!");
            }
            Number = number;
        }

        public string GetFormattedNumber()
        {
            return $"[SDT chuan hoa]: {Number}";
        }
    }

    public class ReplaceDataValueWithObjectAfter
    {
        public string OrderId { get; set; }
        public PhoneNumberObject CustomerPhone { get; set; } // Sử dụng đối tượng thay vì chuỗi nguyên thủy

        public ReplaceDataValueWithObjectAfter(string orderId, PhoneNumberObject customerPhone)
        {
            OrderId = orderId;
            CustomerPhone = customerPhone;
        }

        public void PrintOrderInfo()
        {
            Console.WriteLine($"[After] Don hang: {OrderId} | {CustomerPhone.GetFormattedNumber()}");
        }
    }
}