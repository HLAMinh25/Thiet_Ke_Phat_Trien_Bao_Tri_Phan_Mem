namespace Bai3_Builder
{
    public class InvoiceDirector
    {
        public void BuildPromotionInvoice(ISalesInvoiceBuilder builder, string staffId)
        {
            builder.SetHeader("HD-2026-001", staffId);
            builder.AddItem("Thuốc trừ bệnh Anvil 5SC", 120000m, 10);
            builder.AddItem("Thuốc trừ sâu Regent 800WG", 85000m, 5);
            builder.SetShippingFee(50000m);
            builder.SetExtraServiceFee(30000m);
            builder.ApplyDiscount(100000m); // Giảm giá khuyến mãi
        }
    }
}