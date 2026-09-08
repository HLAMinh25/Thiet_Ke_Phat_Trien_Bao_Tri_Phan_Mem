using System;

namespace NongDuocAnGiang.DesignPatterns.Composite
{
    public class Product : InventoryComponent
    {
        private decimal _unitPrice;

        public Product(string name, decimal unitPrice) : base(name)
        {
            this._unitPrice = unitPrice;
        }

        // Leaf không thể chứa các thành phần con nên trả về false
        public override bool IsComposite()
        {
            return false;
        }

        // Giá của Leaf chính là giá của sản phẩm đó
        public override decimal CalculateTotalPrice()
        {
            return _unitPrice;
        }

        public override string DisplayInfo(int depth = 0)
        {
            return new String('-', depth) + $" Sản phẩm: {_name} (Giá: {_unitPrice:N0} VND)\n";
        }
    }
}