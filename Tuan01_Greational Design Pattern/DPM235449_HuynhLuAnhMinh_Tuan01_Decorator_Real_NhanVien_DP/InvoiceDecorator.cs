using System;

namespace NongDuocAnGiang.DesignPatterns.Decorator
{
    public abstract class InvoiceDecorator : IInvoice
    {
        protected IInvoice _invoice;

        public InvoiceDecorator(IInvoice invoice)
        {
            this._invoice = invoice;
        }

        // Chuyển tiếp lời gọi đến đối tượng được bọc
        public virtual string GetDescription()
        {
            return _invoice.GetDescription();
        }

        public virtual decimal CalculateTotal()
        {
            return _invoice.CalculateTotal();
        }
    }
}