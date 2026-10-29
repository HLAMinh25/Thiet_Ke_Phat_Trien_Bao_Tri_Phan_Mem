using System;

namespace AnGiangPesticideRefactoring
{
    // Lớp cha được làm sạch, chỉ giữ lại các trường chung
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

    // Trường dữ liệu ToxicityWarning đã được Push Down xuống đúng lớp con cần sử dụng
    public class InsecticideAfter : PesticideProductAfter
    {
        public string ToxicityWarning { get; set; } // Đẩy xuống lớp con (Push Down Field)

        public InsecticideAfter(string name, double price, string toxicityWarning) : base(name, price)
        {
            ToxicityWarning = toxicityWarning;
        }
    }

    public class FoliarFertilizerAfter : PesticideProductAfter
    {
        public FoliarFertilizerAfter(string name, double price) : base(name, price)
        {
            // Không còn bị vướng thuộc tính cảnh báo độc tính không liên quan
        }
    }
}