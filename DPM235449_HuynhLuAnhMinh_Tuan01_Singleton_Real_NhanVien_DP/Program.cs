using System;

namespace Bai5_Singleton
{
    public sealed class UserSessionManager
    {
        private static UserSessionManager _instance;
        private static readonly object _lock = new object();

        public string LoggedInUserId { get; private set; }
        public string StaffName { get; private set; }
        public string Role { get; private set; }
        public DateTime LoginTime { get; private set; }

        private UserSessionManager() { }

        public static UserSessionManager GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new UserSessionManager();
                    }
                }
            }
            return _instance;
        }

        public void Login(string userId, string staffName, string role)
        {
            LoggedInUserId = userId;
            StaffName = staffName;
            Role = role;
            LoginTime = DateTime.Now;
            Console.WriteLine($"[Đăng nhập thành công] NV: {StaffName} | Quyền: {Role} | Thời gian: {LoginTime:HH:mm:ss}");
        }

        public void DisplaySession()
        {
            Console.WriteLine($"[Session Hiện Tại] UserID: {LoggedInUserId} | Name: {StaffName} | Role: {Role}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== BÀI 5: SINGLETON - PHIÊN ĐĂNG NHẬP NHÂN VIÊN ===\n");

            // Lấy Instance lần 1
            UserSessionManager session1 = UserSessionManager.GetInstance();
            session1.Login("NV001", "Nguyễn Văn A", "NhanVienBanHang");

            // Lấy Instance lần 2 ở module khác
            UserSessionManager session2 = UserSessionManager.GetInstance();
            session2.DisplaySession();

            // So sánh 2 thể hiện
            if (ReferenceEquals(session1, session2))
            {
                Console.WriteLine("\n[Xác nhận] Chi có DUY NHẤT 1 thể hiện SessionManager tồn tại trong bộ nhớ.");
            }

            Console.ReadLine();
        }
    }
}