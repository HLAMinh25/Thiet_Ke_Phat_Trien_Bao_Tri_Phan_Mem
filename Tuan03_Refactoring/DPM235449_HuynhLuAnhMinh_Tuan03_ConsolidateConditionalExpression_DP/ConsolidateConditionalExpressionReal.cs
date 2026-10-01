using System;

namespace AnGiangPesticideRefactoring
{
    public class ConsolidateConditionalExpressionReal
    {
        // Nghiệp vụ thực tế: Kiểm tra điều kiện miễn phí vận chuyển lô thuốc nông dược
        public bool CheckFreeShippingEligibility(double orderTotalValue, bool isTierOneAgency, bool isWinterSpringSeasonCampaign)
        {
            // Áp dụng Consolidate Conditional Expression: Gộp các tiêu chí được miễn phí ship thành một biểu thức rõ ràng
            if (HasMetFreeShippingCriteria(orderTotalValue, isTierOneAgency, isWinterSpringSeasonCampaign))
            {
                Console.WriteLine("[Logistics An Giang] Dai ly du dieu kien mien phi van chuyen lo hang!");
                return true;
            }

            Console.WriteLine("[Logistics An Giang] Ap dụng phí vận chuyển tiêu chuẩn cho đơn hàng.");
            return false;
        }

        // Phương thức gộp các điều kiện logic
        private bool HasMetFreeShippingCriteria(double orderTotalValue, bool isTierOneAgency, bool isWinterSpringSeasonCampaign)
        {
            return orderTotalValue >= 2000000 || isTierOneAgency || isWinterSpringSeasonCampaign;
        }
    }
}