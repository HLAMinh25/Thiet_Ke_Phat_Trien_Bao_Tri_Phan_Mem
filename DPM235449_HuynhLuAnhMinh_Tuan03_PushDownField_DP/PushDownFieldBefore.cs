using System;

namespace AnGiangPesticideRefactoring
{
    // Lớp cha ôm đồm trường dữ liệu không phải lớp con nào cũng dùng
    public class PesticideProductBefore
    {
        public string ProductName { get; set; }
        public double BasePrice { get; set; }
        public string ToxicityWarning { get; set; } // Trường dữ liệu bị đặt sai vị trí ở lớp cha
    }

    public class InsecticideBefore : PesticideProductBefore
    {
        // Sử dụng ToxicityWarning
    }

    public class FoliarFertilizerBefore : PesticideProductBefore
    {
        // Không dùng ToxicityWarning nhưng vẫn bị gánh vác thuộc tính này
    }
}