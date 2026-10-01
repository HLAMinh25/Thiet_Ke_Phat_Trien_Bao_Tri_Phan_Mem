using System;

namespace AnGiangPesticideRefactoring
{
    public class PesticideCategoryAfter
    {
        public string CategoryName { get; set; }
        public double BasePrice { get; set; }
        public double SpecialTaxRate { get; set; }

        public PesticideCategoryAfter(string name, double price, double taxRate)
        {
            CategoryName = name;
            BasePrice = price;
            SpecialTaxRate = taxRate;
        }

        // Phương thức đã được chuyển (Move Method) đến đúng lớp chứa dữ liệu của nó
        public double CalculateTotalBatchValue(int quantity)
        {
            double subTotal = quantity * BasePrice;
            double taxAmount = subTotal * SpecialTaxRate;
            return subTotal + taxAmount;
        }
    }

    public class MoveMethodAfter
    {
        public string BatchCode { get; set; }
        public int Quantity { get; set; }
        public PesticideCategoryAfter Category { get; set; }

        public MoveMethodAfter(string batchCode, int quantity, PesticideCategoryAfter category)
        {
            BatchCode = batchCode;
            Quantity = quantity;
            Category = category;
        }

        // Lớp này giờ đây chỉ việc ủy quyền gọi hàm sang lớp Category
        public double GetBatchValue()
        {
            return Category.CalculateTotalBatchValue(Quantity);
        }
    }
}