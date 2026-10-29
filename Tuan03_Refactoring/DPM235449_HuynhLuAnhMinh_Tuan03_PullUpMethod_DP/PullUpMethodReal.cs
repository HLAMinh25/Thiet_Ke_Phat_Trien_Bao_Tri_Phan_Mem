using System;

namespace AnGiangPesticideRefactoring
{
    // Lớp cơ sở chung cho các lô hàng nông dược tại An Giang (Pull Up Method Target)
    public abstract class PesticideBatchBase
    {
        public string BatchCode { get; set; }

        protected PesticideBatchBase(string batchCode)
        {
            BatchCode = batchCode;
        }

        // Áp dụng Pull Up Method: Đưa phương thức kiểm tra & chuẩn hóa mã lô hàng lên lớp cha chung
        public virtual string FormatAndValidateBatchCode()
        {
            if (string.IsNullOrWhiteSpace(BatchCode))
            {
                throw new ArgumentException("Ma lo hang khong duoc de trong!");
            }

            // Chuẩn hóa định dạng mã lô hàng theo quy chuẩn của công ty nông dược An Giang (In hoa toàn bộ)
            string cleanedCode = BatchCode.Trim().ToUpper();
            Console.WriteLine($"[Kho An Giang] Da chuan hoa ma lo hang: {cleanedCode}");
            return cleanedCode;
        }
    }

    // Lớp con 1: Lô thuốc trừ sâu nhập khẩu
    public class ImportedInsecticideBatchReal : PesticideBatchBase
    {
        public string CountryOfOrigin { get; set; }

        public ImportedInsecticideBatchReal(string batchCode, string countryOfOrigin) : base(batchCode)
        {
            CountryOfOrigin = countryOfOrigin;
        }

        // Không cần viết lại hàm kiểm tra mã lô hàng nữa nhờ kế thừa từ lớp cha (Pull Up Method)
    }

    // Lớp con 2: Lô thuốc trừ bệnh nội địa
    public class DomesticFungicideBatchReal : PesticideBatchBase
    {
        public string FactoryLocation { get; set; }

        public DomesticFungicideBatchReal(string batchCode, string factoryLocation) : base(batchCode)
        {
            FactoryLocation = factoryLocation;
        }

        // Không cần viết lại hàm kiểm tra mã lô hàng nữa nhờ kế thừa từ lớp cha (Pull Up Method)
    }
}