using System;

namespace AnGiangPesticideRefactoring
{
    // Lớp cha chung quản lý vật tư kho An Giang (chỉ chứa các thuộc tính chung thực sự)
    public abstract class InventoryItemBase
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public double UnitPrice { get; set; }

        protected InventoryItemBase(string itemCode, string itemName, double unitPrice)
        {
            ItemCode = itemCode;
            ItemName = itemName;
            UnitPrice = unitPrice;
        }

        public virtual void PrintItemSummary()
        {
            Console.WriteLine($"[Kho An Giang] Ma: {ItemCode} | Ten: {ItemName} | Gia: {UnitPrice:N0} VND");
        }
    }

    // Lớp con 1: Thuốc trừ sâu hóa học (Cần có thêm quy định số ngày cách ly trước khi thu hoạch)
    public class ChemicalInsecticideItem : InventoryItemBase
    {
        // Áp dụng Push Down Field: Thuộc tính này chỉ thuộc về dòng thuốc trừ sâu hóa học
        public int QuarantinePeriodDays { get; set; }

        public ChemicalInsecticideItem(string itemCode, string itemName, double unitPrice, int quarantineDays)
            : base(itemCode, itemName, unitPrice)
        {
            QuarantinePeriodDays = quarantineDays;
        }

        public override void PrintItemSummary()
        {
            base.PrintItemSummary();
            Console.WriteLine($"-> [Dac thu] Thoi gian cach ly truoc khi thu hoạch: {QuarantinePeriodDays} ngay");
        }
    }

    // Lớp con 2: Phân bón lá hữu cơ sinh học (Không yêu cầu thời gian cách ly nghiêm ngặt như thuốc hóa học)
    public class OrganicFoliarFertilizerItem : InventoryItemBase
    {
        public double OrganicNutrientRate { get; set; } // Thuộc tính đặc thù riêng của phân bón sinh học

        public OrganicFoliarFertilizerItem(string itemCode, string itemName, double unitPrice, double nutrientRate)
            : base(itemCode, itemName, unitPrice)
        {
            OrganicNutrientRate = nutrientRate;
        }

        public override void PrintItemSummary()
        {
            base.PrintItemSummary();
            Console.WriteLine($"-> [Dac thu] Ty le ham luong huu co sinh hoc: {OrganicNutrientRate}%");
        }
    }
}