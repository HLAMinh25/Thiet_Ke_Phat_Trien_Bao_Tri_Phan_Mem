using System;

namespace NongDuocAnGiang.DesignPatterns.Decorator
{
    public class DiscountDecorator : InvoiceDecorator
    {
        private readonly decimal _discountAmount;

        public DiscountDecorator(IInvoice invoice, decimal discountAmount) : base(invoice)
        {
            this._discountAmount = discountAmount;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + $"\n - Giảm giá/Khuyến mãi";
        }

        public override decimal CalculateTotal()
        {
            // Đảm bảo tổng tiền không bị âm
            decimal totalAfterDiscount = base.CalculateTotal() - _discountAmount;
            return totalAfterDiscount > 0 ? totalAfterDiscount : 0;
        }
    }
}