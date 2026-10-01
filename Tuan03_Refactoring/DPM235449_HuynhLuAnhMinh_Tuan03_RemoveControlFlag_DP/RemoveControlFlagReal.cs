using System;
using System.Collections.Generic;

namespace AnGiangPesticideRefactoring
{
    public class PesticideBatchInfo
    {
        public string BatchCode { get; set; }
        public int DaysToExpiry { get; set; } // Số ngày còn lại

        public PesticideBatchInfo(string batchCode, int daysToExpiry)
        {
            BatchCode = batchCode;
            DaysToExpiry = daysToExpiry;
        }
    }

    public class RemoveControlFlagReal
    {
        // Nghiệp vụ thực tế: Kiểm tra nhanh xem kho có tồn tại bất kỳ lô thuốc nào đã hết hạn (<= 0 ngày) cần thu hồi không
        public void InspectExpiredBatches(List<PesticideBatchInfo> inventoryList)
        {
            // Thay vì dùng biến cờ hiệu như `bool hasExpired = false;`, ta dùng lệnh return trực tiếp khi phát hiện vi phạm
            foreach (var batch in inventoryList)
            {
                if (batch.DaysToExpiry <= 0)
                {
                    Console.WriteLine($"[Kho An Giang] CANH BAO: Phat hien lo hang het han '{batch.BatchCode}'! Yeu cau lap lenh phong toa xuat kho ngay lap tuc.");
                    return; // Thoát ngay lập tức, loại bỏ hoàn toàn biến cờ hiệu (Remove Control Flag)
                }
            }

            Console.WriteLine("[Kho An Giang] Tat ca cac lo hang trong danh muc deu con han su dung an toan.");
        }
    }
}