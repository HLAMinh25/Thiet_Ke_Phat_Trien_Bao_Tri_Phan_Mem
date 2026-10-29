using System;

namespace AnGiangPesticideRefactoring
{
    public class SeparateQueryFromModifierReal
    {
        public string AgencyName { get; set; }
        public double CurrentDebt { get; set; }
        public double CreditLimit { get; set; }
        public bool IsAccountLocked { get; private set; }

        public SeparateQueryFromModifierReal(string agencyName, double currentDebt, double creditLimit)
        {
            AgencyName = agencyName;
            CurrentDebt = currentDebt;
            CreditLimit = creditLimit;
            IsAccountLocked = false;
        }

        // 1. Phương thức Query: Chỉ truy vấn kiểm tra xem đại lý có vượt hạn mức công nợ hay không (Không thay đổi dữ liệu)
        public bool HasExceededCreditLimit()
        {
            return CurrentDebt > CreditLimit;
        }

        // 2. Phương thức Modifier: Thực hiện hành động khóa tài khoản đại lý khi vi phạm công nợ
        public void LockAgencyAccountDueToDebt()
        {
            if (HasExceededCreditLimit())
            {
                IsAccountLocked = true;
                Console.WriteLine($"[Tai Chinh An Giang] CANH BAO: Dai ly '{AgencyName}' da vuot han muc cong no cho phep!");
                Console.WriteLine($"-> Trang thai: Tai khoan da bi KHOA tu dong de dam bảo an toàn tín dụng.");
            }
            else
            {
                Console.WriteLine($"[Tai Chinh An Giang] Dai ly '{AgencyName}' hoat động binh thuong trong han muc tin dung.");
            }
        }
    }
}