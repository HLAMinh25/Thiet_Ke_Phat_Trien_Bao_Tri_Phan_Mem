using System;

namespace NongDuocAnGiang.DesignPatterns.Facade
{
    public class ReportingFacade
    {
        protected InventorySubsystem _inventory;
        protected FinancialSubsystem _financial;
        protected ReportExportSubsystem _export;

        public ReportingFacade(InventorySubsystem inventory, FinancialSubsystem financial, ReportExportSubsystem export)
        {
            this._inventory = inventory;
            this._financial = financial;
            this._export = export;
        }

        // Phương thức đơn giản hóa toàn bộ quy trình tạo báo cáo
        public void GenerateComprehensiveReport(DateTime fromDate, DateTime toDate)
        {
            Console.WriteLine("Facade đang điều phối các hệ thống con để tạo báo cáo...");

            string reportContent = "";

            // Lấy dữ liệu từ các module khác nhau
            reportContent += _inventory.GetInventoryData(fromDate, toDate) + "\n";
            reportContent += _inventory.CheckLowStockItems() + "\n";
            reportContent += _financial.CalculateTotalRevenue(fromDate, toDate) + "\n";
            reportContent += _financial.SummarizeDiscountsAndShipping();

            // Định dạng và xuất báo cáo
            _export.FormatHeader("Báo Cáo Thống Kê Tổng Hợp");
            _export.ExportToPdf(reportContent);
        }
    }
}