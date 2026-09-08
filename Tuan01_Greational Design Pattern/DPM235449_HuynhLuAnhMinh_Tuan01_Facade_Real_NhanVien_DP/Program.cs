using System;

namespace NongDuocAnGiang.DesignPatterns.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo các hệ thống con (Thường được Inject qua Dependency Injection)
            InventorySubsystem inventory = new InventorySubsystem();
            FinancialSubsystem financial = new FinancialSubsystem();
            ReportExportSubsystem export = new ReportExportSubsystem();

            // Khởi tạo Facade
            ReportingFacade facade = new ReportingFacade(inventory, financial, export);

            // Client chỉ cần gọi 1 hàm duy nhất và truyền tham số, thay vì phải gọi hàng tá hàm từ 3 class khác nhau
            DateTime tuNgay = new DateTime(2026, 09, 01);
            DateTime denNgay = new DateTime(2026, 09, 30);

            facade.GenerateComprehensiveReport(tuNgay, denNgay);

            Console.ReadLine();
        }
    }
}