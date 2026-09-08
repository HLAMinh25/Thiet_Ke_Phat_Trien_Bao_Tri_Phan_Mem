using System;

namespace NongDuocAnGiang.DesignPatterns.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== HỆ THỐNG QUẢN LÝ BÁN HÀNG NÔNG DƯỢC ===");
            Console.WriteLine("Chức năng: Phân quyền thống kê hóa đơn giảm giá\n");

            string nhanVienCanKiemTra = "NV_BanHang_01";

            // Kịch bản 1: Một nhân viên bán hàng bình thường cố gắng truy cập báo cáo
            Console.WriteLine("--- KỊCH BẢN 1: Nhân viên Sales đăng nhập ---");
            IReportService salesProxy = new ReportAccessProxy("nguyenvana", "Sales");
            ClientCode(salesProxy, nhanVienCanKiemTra);

            // Kịch bản 2: Quản lý cửa hàng đăng nhập và truy cập báo cáo
            Console.WriteLine("\n--- KỊCH BẢN 2: Quản lý cửa hàng đăng nhập ---");
            IReportService managerProxy = new ReportAccessProxy("lethib", "Manager");
            ClientCode(managerProxy, nhanVienCanKiemTra);

            Console.ReadLine();
        }

        // Client code chỉ làm việc với Interface, không cần biết bên dưới là RealSubject hay Proxy
        static void ClientCode(IReportService reportService, string targetEmployeeId)
        {
            reportService.GenerateDiscountReport(targetEmployeeId);
        }
    }
}