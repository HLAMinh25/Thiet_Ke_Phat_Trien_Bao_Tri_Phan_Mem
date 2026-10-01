using System;

namespace AnGiangPesticideRefactoring
{
    // Lớp mới được trích xuất (Extracted Class) chuyên quản lý thông tin đại lý
    public class AgencyInfo
    {
        public string AgencyName { get; set; }
        public string AgencyPhone { get; set; }
        public string AgencyShippingAddress { get; set; }

        public AgencyInfo(string agencyName, string agencyPhone, string agencyShippingAddress)
        {
            AgencyName = agencyName;
            AgencyPhone = agencyPhone;
            AgencyShippingAddress = agencyShippingAddress;
        }
    }

    public class ExtractClassAfter
    {
        public string OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }

        // Lớp chính giờ đây ủy quyền thông tin đại lý cho lớp AgencyInfo
        public AgencyInfo Agency { get; set; }

        public ExtractClassAfter(string orderId, double totalAmount, AgencyInfo agency)
        {
            OrderId = orderId;
            OrderDate = DateTime.Now;
            TotalAmount = totalAmount;
            Agency = agency;
        }

        public void PrintOrderDetails()
        {
            Console.WriteLine($"Don hang: {OrderId} | Tong tien: {TotalAmount:N0} VND");
            Console.WriteLine($"Dai ly: {Agency.AgencyName} - SDT: {Agency.AgencyPhone} - Dia chi: {Agency.AgencyShippingAddress}");
        }
    }
}