using System;

namespace NongDuocAnGiang.DesignPatterns.Flyweight
{
    public class ProductSharedState
    {
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string Unit { get; set; }

        public ProductSharedState(string productName, string category, string unit)
        {
            ProductName = productName;
            Category = category;
            Unit = unit;
        }
    }
}