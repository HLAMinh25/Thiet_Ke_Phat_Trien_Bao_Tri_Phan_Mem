using System;

namespace AnGiangPesticideRefactoring
{
    // Lớp cha chứa phương thức chung nhưng thực tế chỉ có 1 lớp con cần dùng
    public class PesticideProductBefore
    {
        public string ProductName { get; set; }
        public double BasePrice { get; set; }

        // Phương thức đặt ở lớp cha nhưng phụ thuộc vào loại sản phẩm cụ thể
        public double CalculateSpecialHazardTax()
        {
            if (this is InsecticideBefore)
            {
                return BasePrice * 0.12; // Chỉ thuốc trừ sâu mới chịu thuế đặc biệt này
            }
            return 0.0; // Phân bón không chịu thuế này
        }
    }

    public class InsecticideBefore : PesticideProductBefore { }
    public class FoliarFertilizerBefore : PesticideProductBefore { }
}