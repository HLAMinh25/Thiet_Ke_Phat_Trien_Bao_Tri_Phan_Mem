using System;

namespace AnGiangPesticideRefactoring
{
    public class PesticideCategoryBefore
    {
        public string CategoryName { get; set; }
        public double BasePrice { get; set; }
        public double SpecialTaxRate { get; set; }

        public PesticideCategoryBefore(string name, double price, double taxRate)
        {
            CategoryName = name;
            BasePrice = price;
            SpecialTaxRate = taxRate;
        }
    }

    public class MoveMethodBefore
    {
        public string BatchCode { get; set; }
        public int Quantity { get; set; }
        public PesticideCategoryBefore Category { get; set; }

        public MoveMethodBefore(string batchCode, int quantity, PesticideCategoryBefore category)
        {
            BatchCode = batchCode;
            Quantity = quantity;
            Category = category;
        }

        // Vấn đề: Phương thức này dùng dữ liệu của PesticideCategory nhiều hơn lớp chứa nó
        public double CalculateTotalBatchValue()
        {
            double subTotal = Quantity * Category.BasePrice;
            double taxAmount = subTotal * Category.SpecialTaxRate;
            return subTotal + taxAmount;
        }
    }
}