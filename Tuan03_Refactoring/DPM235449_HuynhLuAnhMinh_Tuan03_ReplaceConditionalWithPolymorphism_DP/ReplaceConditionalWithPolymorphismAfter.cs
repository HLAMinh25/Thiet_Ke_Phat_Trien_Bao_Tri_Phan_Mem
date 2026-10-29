using System;

namespace AnGiangPesticideRefactoring
{
    // Lớp trừu tượng cơ sở (Base Class)
    public abstract class PesticideProductAfter
    {
        public double BasePrice { get; set; }
        public PesticideProductAfter(double basePrice) { BasePrice = basePrice; }

        // Phương thức trừu tượng để các lớp con tự triển khai (Polymorphism)
        public abstract double CalculateDiscountedPrice();
    }

    // Lớp con cho Thuốc trừ sâu
    public class InsecticideAfter : PesticideProductAfter
    {
        public InsecticideAfter(double basePrice) : base(basePrice) { }
        public override double CalculateDiscountedPrice() => BasePrice * 0.90;
    }

    // Lớp con cho Phân bón lá
    public class FoliarFertilizerAfter : PesticideProductAfter
    {
        public FoliarFertilizerAfter(double basePrice) : base(basePrice) { }
        public override double CalculateDiscountedPrice() => BasePrice * 0.85;
    }

    // Lớp con cho Thuốc trừ cỏ
    public class HerbicideAfter : PesticideProductAfter
    {
        public HerbicideAfter(double basePrice) : base(basePrice) { }
        public override double CalculateDiscountedPrice() => BasePrice * 0.95;
    }
}