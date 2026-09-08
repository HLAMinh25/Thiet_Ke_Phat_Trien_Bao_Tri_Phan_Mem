using System;

namespace NongDuocAnGiang.DesignPatterns.Decorator
{
    public class BaseInvoice : IInvoice
    {
        private readonly decimal _productTotalAmount;

        public BaseInvoice(decimal productTotalAmount)
        {
            this._productTotalAmount = productTotalAmount;
        }

        public string GetDescription()
        {
            return "Hóa đơn tiền hàng hóa";
        }

        public decimal CalculateTotal()
        {
            return _productTotalAmount;
        }
    }
}