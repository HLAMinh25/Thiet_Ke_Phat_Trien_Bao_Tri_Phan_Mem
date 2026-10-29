using System;

namespace AnGiangPesticideRefactoring
{
    // Value Object thực tế: Biểu diễn thành phần hoạt chất thuốc bảo vệ thực vật (Immutable)
    public class ActiveIngredientValueObject
    {
        public string IngredientName { get; }
        public string Concentration { get; } // Nồng độ/Hàm lượng (Ví dụ: "50WP", "10SL")

        public ActiveIngredientValueObject(string ingredientName, string concentration)
        {
            IngredientName = ingredientName;
            Concentration = concentration;
        }

        // So sánh tính đồng nhất của thành phần hoạt chất theo giá trị
        public override bool Equals(object obj)
        {
            if (obj is ActiveIngredientValueObject other)
            {
                return IngredientName.Equals(other.IngredientName, StringComparison.OrdinalIgnoreCase)
                       && Concentration.Equals(other.Concentration, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(IngredientName, Concentration);
        }

        public void PrintIngredientInfo()
        {
            Console.WriteLine($"Hoat chat: {IngredientName} ({Concentration})");
        }
    }

    // Class Real: Quản lý thông tin đăng ký mặt hàng thuốc nông dược áp dụng Change Reference to Value
    public class ChangeReferenceToValueReal
    {
        public string ProductCode { get; set; }
        public string CommercialName { get; set; }
        public ActiveIngredientValueObject ActiveIngredient { get; set; } // Lưu trữ dưới dạng Value Object bất biến

        public ChangeReferenceToValueReal(string productCode, string commercialName, ActiveIngredientValueObject activeIngredient)
        {
            ProductCode = productCode;
            CommercialName = commercialName;
            ActiveIngredient = activeIngredient;
        }

        public void PrintProductDetails()
        {
            Console.WriteLine($"[San Pham] Ma: {ProductCode} | Ten thuong mai: {CommercialName}");
            Console.Write("-> ");
            ActiveIngredient.PrintIngredientInfo();
        }
    }
}