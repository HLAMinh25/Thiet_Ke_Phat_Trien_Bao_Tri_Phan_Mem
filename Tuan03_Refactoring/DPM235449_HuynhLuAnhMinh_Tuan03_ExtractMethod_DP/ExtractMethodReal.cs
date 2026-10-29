using System;
using System.Collections.Generic;

namespace AnGiangPesticideRefactoring
{
    // Model mô tả mặt hàng nông dược và chi tiết lô hàng
    public class PesticideItem
    {
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
    }

    public class ExtractMethodReal
    {
        // Hàm chính điều phối quy trình (đã được áp dụng Extract Method triệt để)
        public void ProcessAndPrintOrder(string customerName, List<PesticideItem> items, double shippingFee, double additionalServiceFee, double discountPercent, bool isVip)
        {
            // 1. Trích xuất xử lý in tiêu đề
            PrintHeader(customerName);

            // 2. Trích xuất xử lý tính toán tiền hàng và in danh sách sản phẩm
            double subTotal = CalculateAndPrintItems(items);

            // 3. Trích xuất xử lý nghiệp vụ chiết khấu / khuyến mãi
            double discountAmount = CalculateDiscount(subTotal, discountPercent, isVip);

            // 4. Trích xuất xử lý cộng dồn chi phí vận chuyển & dịch vụ phụ (Theo yêu cầu đề tài)
            double finalAmount = CalculateFinalAmount(subTotal, discountAmount, shippingFee, additionalServiceFee);

            // 5. Trích xuất xử lý in tổng kết tài chính hóa đơn
            PrintFinancialSummary(subTotal, discountAmount, shippingFee, additionalServiceFee, finalAmount);
        }

        // --- CÁC PHƯƠNG THỨC ĐƯỢC TRÍCH XUẤT (EXTRACTED METHODS) ---

        private void PrintHeader(string customerName)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("    CONG TY NONG DUOC AN GIANG - HOA DON BAN HANG");
            Console.WriteLine("==================================================");
            Console.WriteLine($"Khach hang: {customerName}");
            Console.WriteLine($"Ngay lap: {DateTime.Now:dd/MM/yyyy HH:mm}");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Danh sach san pham theo lo:");
        }

        private double CalculateAndPrintItems(List<PesticideItem> items)
        {
            double subTotal = 0;
            foreach (var item in items)
            {
                double itemTotal = item.UnitPrice * item.Quantity;
                subTotal += itemTotal;
                Console.WriteLine($"- {item.ProductName} | SL: {item.Quantity} | Don gia: {item.UnitPrice:N0} | Thanh tien: {itemTotal:N0}");
            }
            return subTotal;
        }

        private double CalculateDiscount(double subTotal, double discountPercent, bool isVip)
        {
            // Nghiệp vụ khuyến mãi, giảm giá cho hóa đơn bán hàng
            if (isVip)
            {
                return subTotal * 0.10; // Giảm 10% cho khách hàng VIP / thân thiết
            }

            if (discountPercent > 0)
            {
                return subTotal * (discountPercent / 100.0);
            }

            return 0;
        }

        private double CalculateFinalAmount(double subTotal, double discountAmount, double shippingFee, double additionalServiceFee)
        {
            double discountedTotal = subTotal - discountAmount;
            // Cộng thêm phí vận chuyển và dịch vụ phụ theo yêu cầu đề tài bảo trì
            return discountedTotal + shippingFee + additionalServiceFee;
        }

        private void PrintFinancialSummary(double subTotal, double discountAmount, double shippingFee, double additionalServiceFee, double finalAmount)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Tam tinh: {subTotal:N0} VND");
            Console.WriteLine($"Chiet khau / Khuyen mai: -{discountAmount:N0} VND");
            Console.WriteLine($"Phi van chuyen: +{shippingFee:N0} VND");
            Console.WriteLine($"Dich vu phu: +{additionalServiceFee:N0} VND");
            Console.WriteLine("==================================================");
            Console.WriteLine($"TONG THANH TOAN: {finalAmount:N0} VND");
            Console.WriteLine("==================================================");
        }
    }
}