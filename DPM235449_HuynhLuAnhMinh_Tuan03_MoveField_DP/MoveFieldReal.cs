using System;

namespace AnGiangPesticideRefactoring
{
    // Lớp cấu hình hệ thống chung (trước đây chứa nhầm trường hoa hồng của đại lý)
    public class SystemConfigReal
    {
        public string Version { get; set; } = "v2.6";
        // Các cấu hình chung toàn hệ thống khác...
    }

    // Lớp hồ sơ đại lý nông dược (nơi trường tỷ lệ hoa hồng/chiết khấu thực sự thuộc về)
    public class AgencyProfileReal
    {
        public string AgencyName { get; set; }
        public string Region { get; set; } // Ví dụ: Long Xuyên, Châu Đốc, Thoại Sơn

        // Áp dụng Move Field: Đưa trường định mức chiết khấu/hoa hồng về đúng lớp AgencyProfileReal quản lý
        public double CommissionRate { get; set; }

        public AgencyProfileReal(string agencyName, string region, double commissionRate)
        {
            AgencyName = agencyName;
            Region = region;
            CommissionRate = commissionRate;
        }

        // Tính tiền hoa hồng chiết khấu cho đơn hàng của đại lý ngay tại lớp chứa dữ liệu
        public double CalculateAgencyCommission(double totalOrderValue)
        {
            return totalOrderValue * CommissionRate;
        }
    }

    // Class Real điều phối
    public class MoveFieldReal
    {
        public SystemConfigReal Config { get; set; }
        public AgencyProfileReal Agency { get; set; }

        public MoveFieldReal(SystemConfigReal config, AgencyProfileReal agency)
        {
            Config = config;
            Agency = agency;
        }

        // Thực hiện nghiệp vụ thông qua lớp đúng nhiệm vụ sau khi Move Field
        public double GetCommissionPayout(double orderValue)
        {
            return Agency.CalculateAgencyCommission(orderValue);
        }
    }
}