using System;

namespace NongDuocAnGiang.DesignPatterns.Bridge
{
    public abstract class SalesOrder
    {
        // Thành phần "Bridge" (Cây cầu) nối sang bộ tính giá
        protected IPriceCalculationStrategy _priceCalculator;

        public SalesOrder(IPriceCalculationStrategy priceCalculator)
        {
            this._priceCalculator = priceCalculator;
        }

        // Đổi phương pháp tính giá linh hoạt lúc runtime nếu cần
        public void SetPriceCalculator(IPriceCalculationStrategy priceCalculator)
        {
            this._priceCalculator = priceCalculator;
        }

        // Phương thức trừu tượng mà các loại đơn hàng (Sỉ/Lẻ) sẽ ghi đè
        public virtual decimal ProcessOrder(string productCode, int quantity)
        {
            // Ủy quyền việc tính giá vốn cho Implementor
            return _priceCalculator.CalculateBaseExportPrice(productCode, quantity);
        }
    }
}