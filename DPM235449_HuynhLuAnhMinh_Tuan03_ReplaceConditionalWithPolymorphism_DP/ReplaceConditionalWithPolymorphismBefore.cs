using System;

namespace AnGiangPesticideRefactoring
{
    public class ProductBefore
    {
        public string Type { get; set; } // "ThuocTruSau", "PhanBonLa", "ThuocTruCoi"
        public double BasePrice { get; set; }

        public ProductBefore(string type, double basePrice)
        {
            Type = type;
            BasePrice = basePrice;
        }

        // Phương thức chứa switch-case phân nhánh hành vi phức tạp
        public double CalculateDiscountedPrice()
        {
            switch (Type)
            {
                case "ThuocTruSau":
                    return BasePrice * 0.90; // Giảm 10%
                case "PhanBonLa":
                    return BasePrice * 0.85; // Giảm 15%
                case "ThuocTruCoi":
                    return BasePrice * 0.95; // Giảm 5%
                default:
                    return BasePrice;
            }
        }
    }
} 