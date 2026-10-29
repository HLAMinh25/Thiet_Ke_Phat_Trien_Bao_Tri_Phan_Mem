using System;

namespace AnGiangPesticideRefactoring
{
    // Đối tượng đang được quản lý dạng Reference Object
    public class CurrencyRateBefore
    {
        public string CurrencyCode { get; set; }
        public double ExchangeRate { get; set; }

        public CurrencyRateBefore(string code, double rate)
        {
            CurrencyCode = code;
            ExchangeRate = rate;
        }
    }

    public class ChangeReferenceToValueBefore
    {
        public string InvoiceId { get; set; }
        public CurrencyRateBefore Currency { get; set; }

        public ChangeReferenceToValueBefore(string invoiceId, CurrencyRateBefore currency)
        {
            InvoiceId = invoiceId;
            Currency = currency;
        }
    }
}