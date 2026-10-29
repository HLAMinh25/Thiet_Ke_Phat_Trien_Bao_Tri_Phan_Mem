using System;

namespace AnGiangPesticideRefactoring
{
    public class RenameMethodReal
    {
        public string BatchId { get; set; }
        public int DaysToExpiry { get; set; }
        public bool IsQuarantineCleared { get; set; }

        public RenameMethodReal(string batchId, int daysToExpiry, bool isQuarantineCleared)
        {
            BatchId = batchId;
            DaysToExpiry = daysToExpiry;
            IsQuarantineCleared = isQuarantineCleared;
        }

        // Trước đây có thể đặt tên hàm mơ hồ là: public bool Check() hay public void RunProcess()
        // Sau khi áp dụng Rename Method, tên phương thức được đổi thành rõ nghĩa, thể hiện đúng nghiệp vụ thực tế:
        public bool VerifyBatchSafetyAndApproveExport()
        {
            Console.WriteLine($"[Kiem Định An Giang] Dang kiem tra an toàn cho lo hang: {BatchId}");

            // Lô thuốc chỉ được duyệt xuất kho khi còn hạn sử dụng (> 0 ngày) và đã qua kiểm dịch an toàn
            if (DaysToExpiry > 0 && IsQuarantineCleared)
            {
                Console.WriteLine($"-> Phê duyệt: Lo hang '{BatchId}' du dieu kien xuat kho cung cap cho dai ly.");
                return true;
            }

            Console.WriteLine($"-> Từ chối: Lo hang '{BatchId}' khong dat tieu chuẩn an toan hoac da het han!");
            return false;
        }
    }
}