using System;

namespace AnGiangPesticideRefactoring
{
    // Lớp cha chung quản lý kho nông dược (đã được lược bỏ các hàm không dùng chung)
    public abstract class WarehouseItemBase
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }

        protected WarehouseItemBase(string itemCode, string itemName, double price)
        {
            ItemCode = itemCode;
            ItemName = itemName;
            Price = price;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"[Kho An Giang] Ma: {ItemCode} | Ten: {ItemName} | Gia: {Price:N0} VND");
        }
    }

    // Lớp con 1: Dòng sản phẩm thuốc trừ sâu hóa học phun xịt (Cần phương thức cấp giấy chứng nhận kiểm dịch)
    public class ChemicalSprayProduct : WarehouseItemBase
    {
        public string HazardClassification { get; set; }

        public ChemicalSprayProduct(string itemCode, string itemName, double price, string hazardClassification)
            : base(itemCode, itemName, price)
        {
            HazardClassification = hazardClassification;
        }

        // Áp dụng Push Down Method: Phương thức này chỉ thuộc về dòng thuốc trừ sâu phun xịt
        public void GenerateQuarantineCertificate()
        {
            Console.WriteLine($"[Chung Nhan An Toan] Da cap chung nhan kiem dich va an toan moi truong cho loai thuoc: {ItemName} (Cap do: {HazardClassification})");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"-> Phan loai nguy hiem: {HazardClassification}");
        }
    }

    // Lớp con 2: Dòng sản phẩm phân bón lá hữu cơ (Không cần quy trình cấp giấy chứng nhận kiểm dịch độc hại)
    public class OrganicLeafFertilizerProduct : WarehouseItemBase
    {
        public string OriginCountry { get; set; }

        public OrganicLeafFertilizerProduct(string itemCode, string itemName, double price, string originCountry)
            : base(itemCode, itemName, price)
        {
            OriginCountry = originCountry;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"-> Xuat xu phan bon: {OriginCountry} (Dat chuan huu co sinh hoc an toan)");
        }
    }
}