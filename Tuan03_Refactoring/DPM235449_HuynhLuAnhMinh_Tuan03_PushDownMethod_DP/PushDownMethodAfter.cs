using System;

namespace AnGiangPesticideRefactoring
{
    // Lớp cha được làm sạch, loại bỏ phương thức không dùng chung
    public abstract class PesticideProductAfter
    {
        public string ProductName { get; set; }
        public double BasePrice { get; set; }

        protected PesticideProductAfter(string name, double price)
        {
            ProductName = name;
            BasePrice = price;
        }
    }

    // Phương thức đặc thù đã được Push Down xuống đúng lớp con cần sử dụng
    public class InsecticideAfter : PesticideProductAfter
    {
        public InsecticideAfter(string name, double price) : base(name, price) { }

        public double CalculateSpecialHazardTax() // Đẩy xuống lớp con (Push Down Method)
        {
            return BasePrice * 0.12;
        }
    }

    public class FoliarFertilizerAfter : PesticideProductAfter
    {
        public FoliarFertilizerAfter(string name, double price) : base(name, price)
        {
            // Không bị vướng phương thức tính thuế độc hại không liên quan
        }
    }
}