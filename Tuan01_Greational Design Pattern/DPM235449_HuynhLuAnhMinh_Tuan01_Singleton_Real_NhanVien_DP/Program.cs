using System;

namespace Bai5_Singleton
{
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
                Console.WriteLine("\n[Xác nhận] Chỉ có DUY NHẤT 1 thể hiện SessionManager tồn tại trong bộ nhớ.");
            }

            Console.ReadLine();
        }
    }
}