using System;

namespace NongDuocAnGiang.DesignPatterns.Bridge
{
    public class RetailOrder : SalesOrder
    {
        public RetailOrder(IPriceCalculationStrategy priceCalculator) : base(priceCalculator)
        {
        }

        public override decimal ProcessOrder(string productCode, int quantity)
        {
            Console.WriteLine("\n--- XỬ LÝ ĐƠN HÀNG BÁN LẺ ---");
            // 1. Lấy giá gốc từ Bridge
            decimal basePrice = base.ProcessOrder(productCode, quantity);

            // 2. Logic riêng của Bán Lẻ: Cộng thêm lợi nhuận gộp 30% bán lẻ
            decimal margin = basePrice * 0.30m;
            decimal finalPrice = basePrice + margin;

            Console.WriteLine($"   => Tiền hàng (giá vốn): {basePrice:N0} VND");
            Console.WriteLine($"   => Lợi nhuận bán lẻ (30%): +{margin:N0} VND");
            Console.WriteLine($"   => TỔNG THU: {finalPrice:N0} VND");

            return finalPrice;
        }
    }
}