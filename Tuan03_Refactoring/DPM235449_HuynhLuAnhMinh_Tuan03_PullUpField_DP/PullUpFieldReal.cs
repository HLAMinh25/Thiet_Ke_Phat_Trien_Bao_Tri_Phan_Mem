using System;

namespace AnGiangPesticideRefactoring
{
    // Lớp cơ sở chung cho mọi mặt hàng tồn kho tại kho An Giang (Pull Up Field Target)
    public abstract class BaseInventoryItem
    {
        public string BatchCode { get; set; }      // Thuộc tính chung được Pull Up lên lớp cha
        public DateTime ManufactureDate { get; set; } // Thuộc tính chung được Pull Up lên lớp cha

        protected BaseInventoryItem(string batchCode, DateTime manufactureDate)
        {
            BatchCode = batchCode;
            ManufactureDate = manufactureDate;
        }

        public void PrintBaseItemInfo()
        {
            Console.WriteLine($"[Kho An Giang] Ma lo: {BatchCode} | Ngay SX: {ManufactureDate:dd/MM/yyyy}");
        }
    }

    // Lớp con 1: Sản phẩm thuốc trừ sâu dạng lỏng
    public class LiquidInsecticideBatch : BaseInventoryItem
    {
        public double VolumeInLiters { get; set; } // Dung tích riêng biệt của dạng lỏng

        public LiquidInsecticideBatch(string batchCode, DateTime mfgDate, double volumeInLiters)
            : base(batchCode, mfgDate)
        {
            VolumeInLiters = volumeInLiters;
        }

        public void PrintLiquidDetails()
        {
            PrintBaseItemInfo();
            Console.WriteLine($"-> Loai: Thuốc trừ sâu dạng lỏng | Dung tich: {VolumeInLiters} lit");
        }
    }

    // Lớp con 2: Sản phẩm thuốc trừ bệnh dạng hạt
    public class GranularFungicideBatch : BaseInventoryItem
    {
        public double WeightInKg { get; set; } // Khối lượng riêng biệt của dạng hạt

        public GranularFungicideBatch(string batchCode, DateTime mfgDate, double weightInKg)
            : base(batchCode, mfgDate)
        {
            WeightInKg = weightInKg;
        }

        public void PrintGranularDetails()
        {
            PrintBaseItemInfo();
            Console.WriteLine($"-> Loai: Thuốc trừ bệnh dạng hạt | Khoi luong: {WeightInKg} kg");
        }
    }
}