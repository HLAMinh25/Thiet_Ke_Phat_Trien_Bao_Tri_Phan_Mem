using System;

namespace AnGiangPesticideRefactoring
{
    // Lớp mới trích xuất thực tế: Quản lý thông tin vận chuyển và giao nhận lô hàng nông dược
    public class ShippingAndLogisticsInfo
    {
        public string DriverName { get; set; }
        public string TransportVehicleNumber { get; set; } // Biển số xe tải chở vật tư
        public string WarehouseLocation { get; set; }      // Kho xuất hàng (Long Xuyên, Châu Đốc,...)
        public double ShippingFee { get; set; }

        public ShippingAndLogisticsInfo(string driverName, string transportVehicleNumber, string warehouseLocation, double shippingFee)
        {
            DriverName = driverName;
            TransportVehicleNumber = transportVehicleNumber;
            WarehouseLocation = warehouseLocation;
            ShippingFee = shippingFee;
        }

        public void PrintLogisticsSummary()
        {
            Console.WriteLine($"[Logistics] Kho xuat: {WarehouseLocation} | Tai xe: {DriverName} | Xe: {TransportVehicleNumber} | Phi van chuyen: {ShippingFee:N0} VND");
        }
    }

    // Class Real chính: Hóa đơn bán hàng nông dược An Giang sau khi đã trích xuất phần vận chuyển
    public class ExtractClassReal
    {
        public string InvoiceCode { get; set; }
        public string PesticideProductName { get; set; }
        public int Quantity { get; set; }
        public double MerchandiseTotal { get; set; }

        // Thành phần được trích xuất thành một class riêng biệt giúp hóa đơn tinh gọn
        public ShippingAndLogisticsInfo Logistics { get; set; }

        public ExtractClassReal(string invoiceCode, string pesticideProductName, int quantity, double merchandiseTotal, ShippingAndLogisticsInfo logistics)
        {
            InvoiceCode = invoiceCode;
            PesticideProductName = pesticideProductName;
            Quantity = quantity;
            MerchandiseTotal = merchandiseTotal;
            Logistics = logistics;
        }

        public void PrintCompleteInvoice()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine($" HOA DON XUAT KHO NONG DUOC: {InvoiceCode}");
            Console.WriteLine("==================================================");
            Console.WriteLine($"San pham: {PesticideProductName} | SL: {Quantity} | Tien hang: {MerchandiseTotal:N0} VND");
            Logistics.PrintLogisticsSummary();
            double grandTotal = MerchandiseTotal + Logistics.ShippingFee;
            Console.WriteLine($"-> TONG THANH TOAN (Gom van chuyen): {grandTotal:N0} VND");
            Console.WriteLine("==================================================");
        }
    }
}