using System;

namespace AnGiangPesticideRefactoring
{
    // Lớp cơ sở (Base Class) sau khi được Pull Up phương thức tính toán lên
    public abstract class OrderBaseAfter
    {
        // Phương thức chung đã được đẩy lên lớp cha (Pull Up Method)
        public double CalculateVatTax(double subTotal)
        {
            return subTotal * 0.05; // Thuế VAT tiêu chuẩn 5% cho vật tư nông nghiệp
        }
    }

    public class LocalOrderAfter : OrderBaseAfter
    {
        // Kế thừa trực tiếp phương thức từ lớp cha, không bị lặp code
    }

    public class ExportOrderAfter : OrderBaseAfter
    {
        // Kế thừa trực tiếp phương thức từ lớp cha, không bị lặp code
    }
}