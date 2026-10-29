using System;

namespace AnGiangPesticideRefactoring
{
    // Lớp phụ quá nhỏ, gần như không cần thiết phải tách rời (Inline Class candidate)
    public class AgencyPhoneNumberBefore
    {
        public string AreaCode { get; set; }
        public string Number { get; set; }

        public AgencyPhoneNumberBefore(string areaCode, string number)
        {
            AreaCode = areaCode;
            Number = number;
        }

        public string GetFullPhoneNumber()
        {
            return $"({AreaCode}) {Number}";
        }
    }

    public class InlineClassBefore
    {
        public string AgencyName { get; set; }
        public AgencyPhoneNumberBefore PhoneRecord { get; set; } // Phải ủy quyền qua một lớp quá nhỏ

        public InlineClassBefore(string agencyName, AgencyPhoneNumberBefore phoneRecord)
        {
            AgencyName = agencyName;
            PhoneRecord = phoneRecord;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Dai ly: {AgencyName} - SDT: {PhoneRecord.GetFullPhoneNumber()}");
        }
    }
}