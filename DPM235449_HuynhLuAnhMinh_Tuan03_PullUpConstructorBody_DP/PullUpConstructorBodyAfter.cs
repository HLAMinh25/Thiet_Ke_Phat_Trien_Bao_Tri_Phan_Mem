using System;

namespace AnGiangPesticideRefactoring
{
    public class OrderItemAfterBase
    {
        public string Name { get; set; }
        public double Price { get; set; }

        // Constructor của lớp cha chứa phần thân được Pull Up lên
        protected OrderItemAfterBase(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }

    public class RetailOrderItemAfter : OrderItemAfterBase
    {
        public int RetailDiscount { get; set; }

        // Gọi constructor của lớp cha thông qua base(...)
        public RetailOrderItemAfter(string name, double price, int retailDiscount) : base(name, price)
        {
            RetailDiscount = retailDiscount;
        }
    }

    public class WholesaleOrderItemAfter : OrderItemAfterBase
    {
        public int WholesaleBulkBonus { get; set; }

        // Gọi constructor của lớp cha thông qua base(...)
        public WholesaleOrderItemAfter(string name, double price, int wholesaleBulkBonus) : base(name, price)
        {
            WholesaleBulkBonus = wholesaleBulkBonus;
        }
    }
}