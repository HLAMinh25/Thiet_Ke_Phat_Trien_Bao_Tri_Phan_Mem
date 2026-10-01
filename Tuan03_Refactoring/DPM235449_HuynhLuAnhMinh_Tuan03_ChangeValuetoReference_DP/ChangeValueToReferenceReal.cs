using System;
using System.Collections.Generic;

namespace AnGiangPesticideRefactoring
{
    // Lớp sản phẩm thuốc nông dược dưới dạng Reference Object được quản lý tập trung
    public class PesticideProductReference
    {
        public string ProductCode { get; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }

        // Từ điển tĩnh lưu trữ danh sách sản phẩm duy nhất theo mã
        private static readonly Dictionary<string, PesticideProductReference> productRegistry = new Dictionary<string, PesticideProductReference>();

        private PesticideProductReference(string productCode, string productName, double unitPrice)
        {
            ProductCode = productCode;
            ProductName = productName;
            UnitPrice = unitPrice;
        }

        // Đảm bảo chỉ có một instance duy nhất cho mỗi mã sản phẩm thuốc bảo vệ thực vật (Change Value to Reference)
        public static PesticideProductReference GetRegisteredProduct(string productCode, string productName, double unitPrice)
        {
            if (!productRegistry.ContainsKey(productCode))
            {
                productRegistry[productCode] = new PesticideProductReference(productCode, productName, unitPrice);
            }
            return productRegistry[productCode];
        }
    }

    // Class Real: Quản lý chi tiết hóa đơn bán hàng nông dược An Giang
    public class ChangeValueToReferenceReal
    {
        public string InvoiceNumber { get; set; }
        public PesticideProductReference Product { get; set; } // Tham chiếu chung tới đối tượng sản phẩm
        public int Quantity { get; set; }

        public ChangeValueToReferenceReal(string invoiceNumber, string productCode, string productName, double unitPrice, int quantity)
        {
            InvoiceNumber = invoiceNumber;
            // Lấy tham chiếu đối tượng sản phẩm từ kho đăng ký chung
            Product = PesticideProductReference.GetRegisteredProduct(productCode, productName, unitPrice);
            Quantity = quantity;
        }

        public double CalculateLineTotal()
        {
            return Product.UnitPrice * Quantity;
        }

        public void PrintInvoiceItemInfo()
        {
            Console.WriteLine($"[Hoa Don: {InvoiceNumber}] San pham: {Product.ProductName} (Ma: {Product.ProductCode}) | Don gia: {Product.UnitPrice:N0} | SL: {Quantity} | Thanh tien: {CalculateLineTotal():N0} VND");
        }
    }
}