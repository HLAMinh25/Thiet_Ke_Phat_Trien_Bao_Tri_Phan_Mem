using System;

namespace RefactoringGuru.DesignPatterns.Composite.Conceptual
{
    // Lớp cơ sở Component khai báo các thao tác chung cho cả đối tượng đơn giản và phức tạp.
    abstract class Component
    {
        public Component() { }

        public abstract string Operation();

        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual bool IsComposite()
        {
            return true;
        }
    }
}