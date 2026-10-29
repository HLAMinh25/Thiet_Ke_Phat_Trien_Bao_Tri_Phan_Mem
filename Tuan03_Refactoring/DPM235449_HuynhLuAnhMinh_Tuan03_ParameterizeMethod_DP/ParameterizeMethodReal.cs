using System;

namespace AnGiangPesticideRefactoring
{
    public class ParameterizeMethodReal
    {
        public string OrderCode { get; set; }
        public double OrderWeightKg { get; set; }

        public ParameterizeMethodReal(string orderCode, double orderWeightKg)
        {
            OrderCode = orderCode;
            OrderWeightKg = orderWeightKg;
        }

        // Nghiệp vụ thực tế: Tính toán chi phí vận chuyển lô thuốc bảo vệ thực vật theo tham số phụ phí khu vực
        // Thay vì tách thành nhiều hàm tính phí cho từng huyện/thành phố, ta tham số hóa đơn giá cước `ratePerKg` vào một hàm chung.
        public double CalculateRegionalShippingFee(double ratePerKg)
        {
            if (ratePerKg <= 0)
            {
                throw new ArgumentException("Don gia cuoc van chuyen phai lon hon 0!");
            }

            double totalShippingFee = OrderWeightKg * ratePerKg;
            return totalShippingFee;
        }

        public void PrintShippingSummary(string regionName, double ratePerKg)
        {
            double fee = CalculateRegionalShippingFee(ratePerKg);
            consoleLogResult(regionName, fee);
        }

        private void consoleLogResult(string regionName, double fee)
        {
            Console.WriteLine($"[Logistics An Giang] Don hang: {OrderCode} | Khoi luong: {OrderWeightKg} kg");
            Console.WriteLine($"-> Khu vuc giao: {regionName} | Phi van chuyen thuc te: {fee:N0} VND");
        }
    }
}