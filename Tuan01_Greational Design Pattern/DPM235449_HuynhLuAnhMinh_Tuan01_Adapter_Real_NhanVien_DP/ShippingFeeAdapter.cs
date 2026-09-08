using System;

namespace NongDuocAnGiang.DesignPatterns.Adapter
{
    class ShippingFeeAdapter : IShippingFeeCalculator
    {
        private readonly ExternalLogisticsService _externalService;

        public ShippingFeeAdapter(ExternalLogisticsService externalService)
        {
            this._externalService = externalService;
        }

        public decimal CalculateShipping(string invoiceId, double distanceInKm)
        {
            Console.WriteLine($"  [Adapter] Đang chuyển đổi dữ liệu hóa đơn '{invoiceId}' sang định dạng đối tác...");

            // Chuyển đổi kiểu dữ liệu (từ double sang float, string sang int) để gọi Adaptee
            int trackingNum = Math.Abs(invoiceId.GetHashCode());
            float distance = (float)distanceInKm;

            // Gọi phương thức từ Adaptee
            float fee = _externalService.FetchFreightCharge(trackingNum, distance);

            // Chuyển đổi dữ liệu trả về kiểu decimal để phù hợp với hệ thống hóa đơn hiện tại
            return (decimal)fee;
        }
    }
}