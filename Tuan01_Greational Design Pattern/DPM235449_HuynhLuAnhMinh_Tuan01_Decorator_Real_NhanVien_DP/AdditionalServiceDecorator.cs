using System;

namespace NongDuocAnGiang.DesignPatterns.Decorator
{
    public class AdditionalServiceDecorator : InvoiceDecorator
    {
        private readonly decimal _serviceFee;
        private readonly string _serviceName;

        public AdditionalServiceDecorator(IInvoice invoice, string serviceName, decimal serviceFee) : base(invoice)
        {
            this._serviceName = serviceName;
            this._serviceFee = serviceFee;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + $"\n + Dịch vụ phát sinh ({_serviceName})";
        }

        public override decimal CalculateTotal()
        {
            return base.CalculateTotal() + _serviceFee;
        }
    }
}