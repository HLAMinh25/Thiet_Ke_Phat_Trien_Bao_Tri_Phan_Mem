using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringGuru.DesignPatterns.AbstractFactory.Conceptual
{
    // Interface cơ sở cho sản phẩm B, có thể tương tác với sản phẩm A.
    public interface IAbstractProductB
    {
        string UsefulFunctionB();
        string AnotherUsefulFunctionB(IAbstractProductA collaborator);
    }
}