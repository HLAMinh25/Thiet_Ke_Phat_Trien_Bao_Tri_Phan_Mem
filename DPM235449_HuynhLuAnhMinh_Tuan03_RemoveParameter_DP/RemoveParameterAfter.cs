using System;

namespace AnGiangPesticideRefactoring
{
    public class RemoveParameterAfter
    {
        public string StoreRegion { get; set; } = "Long Xuyen";

        // Áp dụng Remove Parameter: Xóa bỏ tham số không cần thiết, sử dụng luôn thuộc tính StoreRegion của lớp
        public double CalculateShippingFee(double orderWeight)
        {
            if (StoreRegion == "Long Xuyen")
            {
                return orderWeight * 5000;
            }
            return orderWeight * 12000;
        }
    }
}