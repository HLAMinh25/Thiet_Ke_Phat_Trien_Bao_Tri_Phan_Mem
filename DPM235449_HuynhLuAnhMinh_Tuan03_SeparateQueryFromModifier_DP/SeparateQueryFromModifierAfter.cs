using System;

namespace AnGiangPesticideRefactoring
{
    public class SeparateQueryFromModifierAfter
    {
        private int stockQuantity = 5;

        // 1. Phương thức Query: Chỉ kiểm tra và trả về kết quả, không làm thay đổi trạng thái
        public bool CheckStockAvailability(int requestedQty)
        {
            return stockQuantity >= requestedQty;
        }

        // 2. Phương thức Modifier: Chỉ thực hiện thay đổi trạng thái dữ liệu (trừ kho)
        public void DeductStock(int requestedQty)
        {
            if (CheckStockAvailability(requestedQty))
            {
                stockQuantity -= requestedQty;
                Console.WriteLine($"[After] Da tru kho thanh cong. Ton kho con lai: {stockQuantity}");
            }
            else
            {
                throw new InvalidOperationException("Khong du hang de tru kho!");
            }
        }
    }
}