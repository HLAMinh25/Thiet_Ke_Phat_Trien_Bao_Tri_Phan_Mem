using System;

namespace AnGiangPesticideRefactoring
{
    public class ExtractClassBefore
    {
        public string OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }

        // Các trường thông tin về đại lý/khách hàng bị ôm đồm trong lớp Order
        public string AgencyName { get; set; }
        public string AgencyPhone { get; set; }
        public string AgencyShippingAddress { get; set; }

        public ExtractClassBefore(string orderId, double totalAmount, string agencyName, string agencyPhone, string agencyShippingAddress)
        {
            OrderId = orderId;
            OrderDate = DateTime.Now;
            TotalAmount = totalAmount;
            AgencyName = agencyName;
            AgencyPhone = agencyPhone;
            AgencyShippingAddress = agencyShippingAddress;
        }

        public void PrintOrderDetails()
        {
            Console.WriteLine($"Don hang: {OrderId} | Tong tien: {TotalAmount:N0} VND");
            Console.WriteLine($"Dai ly: {AgencyName} - SDT: {AgencyPhone} - Dia chi: {AgencyShippingAddress}");
        }
    }
}