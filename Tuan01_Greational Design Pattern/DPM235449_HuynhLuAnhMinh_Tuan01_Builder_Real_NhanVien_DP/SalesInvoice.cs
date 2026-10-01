using System;
using System.Collections.Generic;

namespace Bai3_Builder
{
    public class SalesInvoice
    {
        public string InvoiceId { get; set; }
        public string StaffId { get; set; }
        public List<string> Items { get; set; } = new List<string>();
        public decimal SubTotal { get; set; }
        public decimal ShippingFee { get; set; }
        public decimal ExtraServiceFee { get; set; }
        public decimal DiscountAmount { get; set; }

        public decimal FinalTotal => SubTotal + ShippingFee + ExtraServiceFee - DiscountAmount;

        public void Display()
        {
            Console.WriteLine($"=== HÓA ĐƠN BÁN HÀNG [{InvoiceId}] ===");
            Console.WriteLine($"Nhân viên lập: {StaffId}");
            Console.WriteLine($"Sản phẩm: {string.Join(", ", Items)}");
            Console.WriteLine($"Tiền hàng: {SubTotal:N0} VNĐ");
            Console.WriteLine($"Phí vận chuyển: {ShippingFee:N0} VNĐ");
            Console.WriteLine($"Dịch vụ phụ: {ExtraServiceFee:N0} VNĐ");
            Console.WriteLine($"Chiết khấu/Giảm giá: -{DiscountAmount:N0} VNĐ");
            Console.WriteLine($"TỔNG CỘNG THANH TOÁN: {FinalTotal:N0} VNĐ\n");
        }
    }
}