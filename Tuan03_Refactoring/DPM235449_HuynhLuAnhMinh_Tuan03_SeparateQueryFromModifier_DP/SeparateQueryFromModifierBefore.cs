using System;

namespace AnGiangPesticideRefactoring
{
    public class SeparateQueryFromModifierBefore
    {
        private int stockQuantity = 5;

        // Vừa trả về kết quả (Query), vừa làm thay đổi dữ liệu nội bộ (Modifier - giảm stock)
        public string CheckAndDeductStock(int requestedQty)
        {
            if (stockQuantity >= requestedQty)
            {
                stockQuantity -= requestedQty; // Side effect: Thay đổi trạng thái kho
                return "Du hang, da tru kho.";
            }
            return "Khong du hang trong kho!";
        }
    }
}