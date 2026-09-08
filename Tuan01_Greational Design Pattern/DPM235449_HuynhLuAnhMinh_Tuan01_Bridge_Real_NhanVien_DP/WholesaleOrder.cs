using System;

namespace NongDuocAnGiang.DesignPatterns.Bridge
{
    public class WholesaleOrder : SalesOrder
    {
        public WholesaleOrder(IPriceCalculationStrategy priceCalculator) : base(priceCalculator)
        {
        }

        public override decimal ProcessOrder(string productCode, int quantity)
        {
            Console.WriteLine("\n--- XỬ LÝ ĐƠN HÀNG BÁN SỈ ---");
            // 1. Lấy giá gốc từ Bridge
            decimal basePrice = base.ProcessOrder(productCode, quantity);

            // 2. Logic riêng của Bán Sỉ: Chiết khấu 15% cho khách sỉ
            decimal discount = basePrice * 0.15m;
            decimal finalPrice = basePrice - discount;

            Console.WriteLine($"   => Tiền hàng gốc: {basePrice:N0} VND");
            Console.WriteLine($"   => Chiết khấu khách sỉ (15%): -{discount:N0} VND");
            Console.WriteLine($"   => TỔNG THU: {finalPrice:N0} VND");

            return finalPrice;
        }
    }
}