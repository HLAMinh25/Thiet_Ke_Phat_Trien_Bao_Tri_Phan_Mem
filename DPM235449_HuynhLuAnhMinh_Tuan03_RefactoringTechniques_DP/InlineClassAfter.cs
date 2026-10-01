using System;

namespace AnGiangPesticideRefactoring
{
    public class InlineClassAfter
    {
        public string AgencyName { get; set; }

        // Các trường dữ liệu từ lớp phụ đã được gộp trực tiếp vào đây (Inline Class)
        public string PhoneAreaCode { get; set; }
        public string PhoneNumber { get; set; }

        public InlineClassAfter(string agencyName, string phoneAreaCode, string phoneNumber)
        {
            AgencyName = agencyName;
            PhoneAreaCode = phoneAreaCode;
            PhoneNumber = phoneNumber;
        }

        public string GetFullPhoneNumber()
        {
            return $"({PhoneAreaCode}) {PhoneNumber}";
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Dai ly: {AgencyName} - SDT: {GetFullPhoneNumber()}");
        }
    }
}