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
}