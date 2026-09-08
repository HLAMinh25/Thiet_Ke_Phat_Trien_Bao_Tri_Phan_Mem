using System;

namespace NongDuocAnGiang.DesignPatterns.Proxy
{
    public class ReportAccessProxy : IReportService
    {
        private RealReportService _realService;
        private readonly string _currentUserRole;
        private readonly string _currentUsername;

        public ReportAccessProxy(string username, string role)
        {
            this._currentUsername = username;
            this._currentUserRole = role;
        }

        public void GenerateDiscountReport(string targetEmployeeId)
        {
            if (CheckAccess())
            {
                // Khởi tạo trễ (Lazy Initialization): Chỉ tạo RealSubject khi thực sự cần
                if (_realService == null)
                {
                    _realService = new RealReportService();
                }

                _realService.GenerateDiscountReport(targetEmployeeId);

                LogAccess(targetEmployeeId);
            }
            else
            {
                Console.WriteLine($"   [Cảnh báo Bảo mật] Lỗi phân quyền! Tài khoản '{_currentUsername}' (Quyền: {_currentUserRole}) không được phép xem báo cáo thống kê này.");
            }
        }

        private bool CheckAccess()
        {
            Console.WriteLine($"\n[Proxy] Đang kiểm tra quyền truy cập hệ thống...");
            // Chỉ cấp Quản lý (Manager) hoặc Quản trị viên (Admin) mới được xem báo cáo
            return _currentUserRole == "Manager" || _currentUserRole == "Admin";
        }

        private void LogAccess(string targetEmployeeId)
        {
            Console.WriteLine($"   [Log Hệ thống] Tài khoản '{_currentUsername}' đã truy xuất báo cáo của '{targetEmployeeId}' vào lúc {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
        }
    }
}