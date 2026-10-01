using System;

namespace AnGiangPesticideRefactoring
{
    // Chuyển thành Value Object bất biến (Immutable Value Object)
    public class CurrencyRateValueAfter
    {
        public string CurrencyCode { get; }
        public double ExchangeRate { get; }

        public CurrencyRateValueAfter(string code, double rate)
        {
            CurrencyCode = code;
            ExchangeRate = rate;
        }

        // Ghi đè Equals để so sánh theo giá trị
        public override bool Equals(object obj)
        {
            if (obj is CurrencyRateValueAfter other)
            {
                return CurrencyCode == other.CurrencyCode && ExchangeRate == other.ExchangeRate;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CurrencyCode, ExchangeRate);
        }
    }

    public class ChangeReferenceToValueAfter
    {
        public string InvoiceId { get; set; }
        public CurrencyRateValueAfter Currency { get; set; }

        public ChangeReferenceToValueAfter(string invoiceId, CurrencyRateValueAfter currency)
        {
            InvoiceId = invoiceId;
            Currency = currency;
        }
    }
}