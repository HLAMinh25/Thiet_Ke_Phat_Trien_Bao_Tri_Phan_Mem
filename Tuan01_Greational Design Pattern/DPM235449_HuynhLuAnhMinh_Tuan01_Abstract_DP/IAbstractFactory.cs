using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringGuru.DesignPatterns.AbstractFactory.Conceptual
{
    // Interface cho Abstract Factory khai báo các phương thức tạo ra sản phẩm trừu tượng.
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();
    }
}
