using System;

namespace NongDuocAnGiang.DesignPatterns.Decorator
{
    public class ShippingFeeDecorator : InvoiceDecorator
    {
        private readonly decimal _shippingFee;

        public ShippingFeeDecorator(IInvoice invoice, decimal shippingFee) : base(invoice)
        {
            this._shippingFee = shippingFee;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + "\n + Chi phí vận chuyển";
        }

        public override decimal CalculateTotal()
        {
            return base.CalculateTotal() + _shippingFee;
        }
    }
}