using System;

namespace NongDuocAnGiang.DesignPatterns.Facade
{
    public class ReportExportSubsystem
    {
        public void FormatHeader(string title)
        {
            Console.WriteLine($"\n========== {title.ToUpper()} ==========");
        }

        public void ExportToPdf(string content)
        {
            Console.WriteLine(content);
            Console.WriteLine("==================================================");
            Console.WriteLine("-> Đang xuất file PDF... Hoàn tất: BaoCaoThongKe.pdf\n");
        }
    }
}