using System;

namespace NongDuocAnGiang.DesignPatterns.Facade
{
    public class FinancialSubsystem
    {
        public string CalculateTotalRevenue(DateTime fromDate, DateTime toDate)
        {
            return $"[Tài chính] Tổng doanh thu bán hàng: 150,000,000 VND";
        }

        public string SummarizeDiscountsAndShipping()
        {
            return "[Tài chính] Chi phí vận chuyển: 2,500,000 VND | Tổng giảm giá: 1,200,000 VND";
        }
    }
}