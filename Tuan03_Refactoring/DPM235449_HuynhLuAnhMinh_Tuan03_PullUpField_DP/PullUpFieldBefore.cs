using System;

namespace AnGiangPesticideRefactoring
{
    // Lớp con 1: Thuốc trừ sâu chứa các trường dữ liệu trùng lặp
    public class InsecticideBefore
    {
        public string ProductName { get; set; } // Lặp lại ở lớp con
        public double BasePrice { get; set; }   // Lặp lại ở lớp con
        public double ToxicityLevel { get; set; }
    }

    // Lớp con 2: Phân bón lá chứa các trường dữ liệu trùng lặp
    public class FoliarFertilizerBefore
    {
        public string ProductName { get; set; } // Lặp lại ở lớp con
        public double BasePrice { get; set; }   // Lặp lại ở lớp con
        public double NitrogenContent { get; set; }
    }

    public class PullUpFieldBefore
    {
        // Minh họa việc sử dụng riêng lẻ từng lớp
    }
}