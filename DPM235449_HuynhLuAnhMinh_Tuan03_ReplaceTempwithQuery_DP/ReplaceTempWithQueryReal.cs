using System;

namespace AnGiangPesticideRefactoring
{
    public class ReplaceTempWithQueryReal
    {
        private string batchCode;
        private double basePricePerUnit;
        private int quantityOrdered;
        private double transportFee;

        public ReplaceTempWithQueryReal(string batchCode, double basePricePerUnit, int quantityOrdered, double transportFee)
        {
            this.batchCode = batchCode;
            this.basePricePerUnit = basePricePerUnit;
            this.quantityOrdered = quantityOrdered;
            this.transportFee = transportFee;
        }

        // Phương thức chính tính tổng giá trị thanh toán của lô hàng nông dược
        public double CalculateFinalBatchBill()
        {
            // Áp dụng Replace Temp with Query: Gọi các phương thức truy vấn thay vì dùng biến tạm rời rạc
            double netProductValue = GetSubTotalMerchandiseValue() - GetBatchDiscountAmount();
            return netProductValue + GetApplicableTransportFee();
        }

        // Query Method 1: Tính giá trị hàng hóa gốc của lô thuốc
        private double GetSubTotalMerchandiseValue()
        {
            return basePricePerUnit * quantityOrdered;
        }

        // Query Method 2: Tính số tiền chiết khấu dựa trên truy vấn tỷ lệ chiết khấu theo phân khúc đại lý
        private double GetBatchDiscountAmount()
        {
            double subTotal = GetSubTotalMerchandiseValue();
            double discountRate = (subTotal >= 1000000) ? 0.15 : 0.08; // Đơn hàng >= 1 triệu giảm 15%, ngược lại giảm 8%
            return subTotal * discountRate;
        }

        // Query Method 3: Truy vấn chi phí vận chuyển (có thể kèm chính sách miễn phí cho đơn hàng lớn)
        private double GetApplicableTransportFee()
        {
            // Nếu tổng giá trị hàng lớn hơn 2 triệu thì miễn phí vận chuyển
            if (GetSubTotalMerchandiseValue() >= 2000000)
            {
                return 0.0;
            }
            return transportFee;
        }
    }
}