using System;

namespace AnGiangPesticideRefactoring
{
    public class RemoveParameterBefore
    {
        public string StoreRegion { get; set; } = "Long Xuyen";

        // Phương thức nhận tham số region nhưng bên trong lại không dùng đến hoặc dùng thuộc tính có sẵn
        public double CalculateShippingFee(double orderWeight, string agencyRegion)
        {
            if (agencyRegion == "Long Xuyen")
            {
                return orderWeight * 5000; // Phí nội thành
            }
            return orderWeight * 12000; // Phí ngoại tỉnh
        }
    }
}