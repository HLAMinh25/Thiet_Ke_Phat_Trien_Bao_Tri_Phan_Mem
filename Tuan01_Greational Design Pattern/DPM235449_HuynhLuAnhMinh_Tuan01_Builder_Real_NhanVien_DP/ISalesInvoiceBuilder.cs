namespace Bai3_Builder
{
    public interface ISalesInvoiceBuilder
    {
        void SetHeader(string invoiceId, string staffId);
        void AddItem(string itemName, decimal price, int qty);
        void SetShippingFee(decimal fee);
        void SetExtraServiceFee(decimal fee);
        void ApplyDiscount(decimal discount);
        SalesInvoice GetInvoice();
    }
}