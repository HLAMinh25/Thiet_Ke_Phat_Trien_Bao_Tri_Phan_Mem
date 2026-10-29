using System;

namespace AnGiangPesticideRefactoring
{
    // Lớp cơ sở (Base Class) sau khi được Pull Up các trường dữ liệu chung lên
    public abstract class PesticideProductAfter
    {
        public string ProductName { get; set; } // Đã được đẩy lên lớp cha (Pull Up Field)
        public double BasePrice { get; set; }   // Đã được đẩy lên lớp cha (Pull Up Field)

        protected PesticideProductAfter(string productName, double basePrice)
        {
            ProductName = productName;
            BasePrice = basePrice;
        }
    }

    public class InsecticideAfter : PesticideProductAfter
    {
        public double ToxicityLevel { get; set; }

        public InsecticideAfter(string name, double price, double toxicity) : base(name, price)
        {
            ToxicityLevel = toxicity;
        }
    }

    public class FoliarFertilizerAfter : PesticideProductAfter
    {
        public double NitrogenContent { get; set; }

        public FoliarFertilizerAfter(string name, double price, double nitrogen) : base(name, price)
        {
            NitrogenContent = nitrogen;
        }
    }
}