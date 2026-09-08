using System;
using System.Collections.Generic;
using System.Text;

namespace NongDuocAnGiang.DesignPatterns.Composite
{
    public class ProductBatch : InventoryComponent
    {
        // Danh sách chứa các thành phần con
        protected List<InventoryComponent> _children = new List<InventoryComponent>();

        public ProductBatch(string name) : base(name)
        {
        }

        public override void Add(InventoryComponent component)
        {
            this._children.Add(component);
        }

        public override void Remove(InventoryComponent component)
        {
            this._children.Remove(component);
        }

        // Tính tổng giá trị bằng cách cộng dồn giá trị của tất cả các thành phần con
        public override decimal CalculateTotalPrice()
        {
            decimal total = 0;
            foreach (var component in _children)
            {
                total += component.CalculateTotalPrice();
            }
            return total;
        }

        public override string DisplayInfo(int depth = 0)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(new String('-', depth) + $" + LÔ/THÙNG HÀNG: {_name}\n");

            // Duyệt qua các thành phần con và gọi đệ quy
            foreach (var component in _children)
            {
                sb.Append(component.DisplayInfo(depth + 2));
            }
            return sb.ToString();
        }
    }
}