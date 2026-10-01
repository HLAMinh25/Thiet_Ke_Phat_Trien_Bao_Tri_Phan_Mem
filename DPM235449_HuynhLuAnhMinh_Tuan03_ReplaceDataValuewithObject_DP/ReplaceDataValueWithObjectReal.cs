using System;

namespace AnGiangPesticideRefactoring
{
    // Lớp đối tượng thay thế cho giá trị mã vùng nguyên thủy
    public class AgencyRegion
    {
        public string RegionCode { get; }
        public string RegionName { get; }
        public double RegionalShippingSurcharge { get; } // Phụ phí vận chuyển theo vùng

        public AgencyRegion(string regionCode)
        {
            RegionCode = regionCode.ToUpper();
            if (RegionCode == "LX")
            {
                RegionName = "Thanh pho Long Xuyen";
                RegionalShippingSurcharge = 15000;
            }
            else if (RegionCode == "CD")
            {
                RegionName = "Thanh pho Chau Doc";
                RegionalShippingSurcharge = 30000;
            }
            else
            {
                RegionName = "Cac huyen/thi xã khac trong tinh An Giang";
                RegionalShippingSurcharge = 45000;
            }
        }

        public void PrintRegionDetails()
        {
            Console.WriteLine($"Khu vực: {RegionName} (Ma: {RegionCode}) | Phu phi van chuyen: {RegionalShippingSurcharge:N0} VND");
        }
    }

    // Class Real: Quản lý thông tin đại lý phân phối nông dược áp dụng Replace Data Value with Object
    public class ReplaceDataValueWithObjectReal
    {
        public string AgencyCode { get; set; }
        public string AgencyName { get; set; }
        public AgencyRegion Region { get; set; } // Thay thế chuỗi mã vùng nguyên thủy bằng đối tượng AgencyRegion

        public ReplaceDataValueWithObjectReal(string agencyCode, string agencyName, string regionCode)
        {
            AgencyCode = agencyCode;
            AgencyName = agencyName;
            Region = new AgencyRegion(regionCode); // Khởi tạo đối tượng Region từ mã vùng
        }

        public void PrintAgencyProfile()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine($" HO SO DAI LÝ PHAN PHOI NONG DUOC: {AgencyName} ({AgencyCode})");
            Console.WriteLine("==================================================");
            Region.PrintRegionDetails();
            Console.WriteLine("==================================================");
        }
    }
}