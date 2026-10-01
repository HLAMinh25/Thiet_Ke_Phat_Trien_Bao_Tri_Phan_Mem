using System;

namespace AnGiangPesticideRefactoring
{
    public class OrderItemBeforeBase
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    // Lớp con 1: Trùng lặp code khởi tạo trong constructor
    public class RetailOrderItemBefore : OrderItemBeforeBase
    {
        public int RetailDiscount { get; set; }

        public RetailOrderItemBefore(string name, double price, int retailDiscount)
        {
            // Đoạn code khởi tạo bị lặp lại ở các lớp con
            Name = name;
            Price = price;
            RetailDiscount = retailDiscount;
        }
    }

    // Lớp con 2: Trùng lặp code khởi tạo trong constructor
    public class WholesaleOrderItemBefore : OrderItemBeforeBase
    {
        public int WholesaleBulkBonus { get; set; }

        public WholesaleOrderItemBefore(string name, double price, int wholesaleBulkBonus)
        {
            // Đoạn code khởi tạo bị lặp lại ở các lớp con
            Name = name;
            Price = price;
            WholesaleBulkBonus = wholesaleBulkBonus;
        }
    }
}