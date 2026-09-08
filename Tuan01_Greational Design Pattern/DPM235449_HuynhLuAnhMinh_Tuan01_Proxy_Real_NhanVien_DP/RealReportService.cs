using System;

namespace NongDuocAnGiang.DesignPatterns.Proxy
{
    public class RealReportService : IReportService
    {
        public void GenerateDiscountReport(string targetEmployeeId)
        {
            Console.WriteLine($"   [Database] Đang tổng hợp dữ liệu hóa đơn...");
            Console.WriteLine($"   [RealSubject] BÁO CÁO: Nhân viên '{targetEmployeeId}' đã bán 15 đơn hàng có áp dụng khuyến mãi, tổng giảm giá: 2,500,000 VND.");
        }
    }
}