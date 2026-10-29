using System;

namespace AnGiangPesticideRefactoring
{
    // Lớp cấu hình chính sách chiết khấu mùa vụ nội bộ của công ty nông dược (Đã đồng bộ tên thuộc tính)
    public class SeasonalPolicyConfig
    {
        public string CampaignName { get; set; } = "Vu Dong Xuan 2026";
        public double SeasonalDiscountRate { get; set; } = 0.12; // Đã đổi tên khớp với lời gọi bên dưới
    }

    // Class Real: Quản lý hóa đơn xuất kho nông dược An Giang
    public class RemoveParameterReal
    {
        public string InvoiceId { get; set; }
        public SeasonalPolicyConfig SeasonalPolicy { get; set; }

        public RemoveParameterReal(string invoiceId, SeasonalPolicyConfig seasonalPolicy)
        {
            InvoiceId = invoiceId;
            SeasonalPolicy = seasonalPolicy;
        }

        // Áp dụng Remove Parameter: Loại bỏ tham số chiết khấu thừa thãi, truy xuất trực tiếp từ SeasonalPolicy
        public double CalculateInvoiceTotalWithDefaultSeasonDiscount(double baseSubTotal)
        {
            double discountAmount = baseSubTotal * SeasonalPolicy.SeasonalDiscountRate;
            double finalAmount = baseSubTotal - discountAmount;

            Console.WriteLine($"[Hoa Don An Giang: {InvoiceId}] Ap dung chinh sach: {SeasonalPolicy.CampaignName}");
            Console.WriteLine($"-> Ty le chiet khau noi bo: {SeasonalPolicy.SeasonalDiscountRate * 100}% | Thanh tien sau chiet khau: {finalAmount:N0} VND");

            return finalAmount;
        }
    }
}