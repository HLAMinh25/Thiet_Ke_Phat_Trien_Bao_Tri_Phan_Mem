namespace Bai3_Builder
{
    public class SalesInvoiceBuilder : ISalesInvoiceBuilder
    {
        private SalesInvoice _invoice = new SalesInvoice();

        public void SetHeader(string invoiceId, string staffId)
        {
            _invoice.InvoiceId = invoiceId;
            _invoice.StaffId = staffId;
        }

        public void AddItem(string itemName, decimal price, int qty)
        {
            _invoice.Items.Add($"{itemName} (x{qty})");
            _invoice.SubTotal += price * qty;
        }

        public void SetShippingFee(decimal fee) => _invoice.ShippingFee = fee;
        public void SetExtraServiceFee(decimal fee) => _invoice.ExtraServiceFee = fee;
        public void ApplyDiscount(decimal discount) => _invoice.DiscountAmount = discount;

        public SalesInvoice GetInvoice()
        {
            SalesInvoice result = _invoice;
            _invoice = new SalesInvoice(); // Reset để dùng lại cho hóa đơn sau
            return result;
        }
    }
}