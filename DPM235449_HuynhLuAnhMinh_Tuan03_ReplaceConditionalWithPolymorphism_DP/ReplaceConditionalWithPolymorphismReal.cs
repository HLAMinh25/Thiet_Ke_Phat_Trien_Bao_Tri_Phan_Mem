using System;

namespace AnGiangPesticideRefactoring
{
    // Interface định nghĩa hành vi tính toán phụ phí vận chuyển & xử lý đặc thù cho vật tư nông dược
    public interface IPesticideCategoryPolicy
    {
        double CalculateLogisticsSurcharge(double baseOrderValue);
        string GetHandlingInstruction();
    }

    // Chính sách cho nhóm thuốc trừ sâu độc tính cao (cần xe chuyên dụng, phụ phí cao)
    public class HighToxicityInsecticidePolicy : IPesticideCategoryPolicy
    {
        public double CalculateLogisticsSurcharge(double baseOrderValue)
        {
            return baseOrderValue * 0.08; // Phụ phí an toàn môi trường 8%
        }

        public string GetHandlingInstruction()
        {
            return "Yeu cau xe tai chuyen dung, co thiet bị bao ho va phong ngua su co hoa chat.";
        }
    }

    // Chính sách cho nhóm phân bón sinh học / hữu cơ (an toàn, phụ phí thấp)
    public class OrganicFertilizerPolicy : IPesticideCategoryPolicy
    {
        public double CalculateLogisticsSurcharge(double baseOrderValue)
        {
            return baseOrderValue * 0.03; // Phụ phí tiêu chuẩn 3%
        }

        public string GetHandlingInstruction()
        {
            return "Van chuyen thong thuong, bao quan noi kho rao, thoang mat.";
        }
    }

    // Class Real: Quản lý chi tiết lô hàng nông dược áp dụng Replace Conditional with Polymorphism
    public class ReplaceConditionalWithPolymorphismReal
    {
        public string BatchId { get; set; }
        public string ProductName { get; set; }
        public double OrderValue { get; set; }
        private IPesticideCategoryPolicy policy; // Sử dụng Interface đa hình thay vì switch-case

        public ReplaceConditionalWithPolymorphismReal(string batchId, string productName, double orderValue, IPesticideCategoryPolicy policy)
        {
            BatchId = batchId;
            ProductName = productName;
            OrderValue = orderValue;
            this.policy = policy;
        }

        public double GetTotalLogisticsCost()
        {
            // Thực thi tính toán đa hình thông qua đối tượng policy mà không cần câu lệnh điều kiện rườm rà
            return policy.CalculateLogisticsSurcharge(OrderValue);
        }

        public void PrintBatchPolicyDetails()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine($" QUY DINH LOGISTICS LO NONG DUOC: {ProductName} ({BatchId})");
            Console.WriteLine("==================================================");
            Console.WriteLine($"Phu phi van chuyen: {GetTotalLogisticsCost():N0} VND");
            Console.WriteLine($"Huong dan xu ly: {policy.GetHandlingInstruction()}");
            Console.WriteLine("==================================================");
        }
    }
}