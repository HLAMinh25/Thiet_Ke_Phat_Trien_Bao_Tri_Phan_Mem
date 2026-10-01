using System;

namespace AnGiangPesticideRefactoring
{
    public class AddParameterReal
    {
        public string InvoiceCode { get; set; }
        public string ProductName { get; set; }

        public AddParameterReal(string invoiceCode, string productName)
        {
            InvoiceCode = invoiceCode;
            ProductName = productName;
        }

        // Nghiệp vụ thực tế: Tính toán tổng hóa đơn xuất kho thuốc nông dược
        // Áp dụng kỹ thuật Add Parameter bằng cách thêm tham số `regionalTransportFee` (phí vận chuyển theo vùng) 
        // và `seasonalVoucherDiscount` (giảm giá voucher mùa vụ) vào phương thức.
        public double CalculateFinalInvoiceAmount(double unitPrice, int quantity, double regionalTransportFee, double seasonalVoucherDiscount)
        {
            double merchandiseSubTotal = unitPrice * quantity;

            // Trừ đi giảm giá voucher mùa vụ (nếu có) sau đó cộng thêm phụ phí vận chuyển thực tế đến đại lý
            double discountedMerchandise = Math.Max(0, merchandiseSubTotal - seasonalVoucherDiscount);
            double grandTotal = discountedMerchandise + regionalTransportFee;

            Console.WriteLine($"[Hoa Don An Giang: {InvoiceCode}] San pham: {ProductName}");
            Console.WriteLine($"-> Tien hang: {merchandiseSubTotal:N0} | Giam voucher: -{seasonalVoucherDiscount:N0} | Phi van chuyen: +{regionalTransportFee:N0}");

            return grandTotal;
        }
    }
}