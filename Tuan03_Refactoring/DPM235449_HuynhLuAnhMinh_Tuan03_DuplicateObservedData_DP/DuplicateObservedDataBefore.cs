using System;

namespace AnGiangPesticideRefactoring
{
    // Lớp giao diện ôm đồm luôn cả logic dữ liệu (Code Smell: Duplicate Observed Data)
    public class DuplicateObservedDataBefore
    {
        private string quantityBoxValue = "10"; // Giá trị hiển thị trên giao diện (UI Text)

        public string QuantityBoxValue
        {
            get => quantityBoxValue;
            set
            {
                quantityBoxValue = value;
                ValidateQuantity(); // Logic validation dính liền trong UI
            }
        }

        private void ValidateQuantity()
        {
            if (int.TryParse(quantityBoxValue, out int qty) && qty < 0)
            {
                Console.WriteLine("[UI Warning] So luong ton kho khong the la so am!");
            }
        }

        public void SimulateUserTyping(string newValue)
        {
            QuantityBoxValue = newValue;
            Console.WriteLine($"[Form UI] Gia tri hien thi tren o nhap: {QuantityBoxValue}");
        }
    }
}