using System;

namespace NongDuocAnGiang.DesignPatterns.Composite
{
    public abstract class InventoryComponent
    {
        protected string _name;

        public InventoryComponent(string name)
        {
            this._name = name;
        }

        // Lớp cơ sở có thể triển khai mặc định cho Add/Remove để các Leaf không cần phải 
        // triển khai nếu không cần thiết.
        public virtual void Add(InventoryComponent component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(InventoryComponent component)
        {
            throw new NotImplementedException();
        }

        // Phương thức giúp Client kiểm tra xem đây có phải là một đối tượng chứa (Composite) không
        public virtual bool IsComposite()
        {
            return true;
        }

        // Các thao tác nghiệp vụ chính
        public abstract decimal CalculateTotalPrice();

        public abstract string DisplayInfo(int depth = 0);
    }
}