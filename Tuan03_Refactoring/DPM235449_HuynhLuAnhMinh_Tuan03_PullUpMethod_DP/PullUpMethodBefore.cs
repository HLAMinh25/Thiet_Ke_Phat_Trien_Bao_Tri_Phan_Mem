using System;

namespace AnGiangPesticideRefactoring
{
    // Lớp con 1: Lặp lại đoạn code tính toán thuế VAT
    public class LocalOrderBefore
    {
        public double CalculateVatTax(double subTotal)
        {
            // Đoạn code tính thuế bị lặp lại ở cả 2 lớp con
            return subTotal * 0.05;
        }
    }

    // Lớp con 2: Lặp lại đoạn code tính toán thuế VAT
    public class ExportOrderBefore
    {
        public double CalculateVatTax(double subTotal)
        {
            // Đoạn code tính thuế bị lặp lại ở cả 2 lớp con
            return subTotal * 0.05;
        }
    }
}