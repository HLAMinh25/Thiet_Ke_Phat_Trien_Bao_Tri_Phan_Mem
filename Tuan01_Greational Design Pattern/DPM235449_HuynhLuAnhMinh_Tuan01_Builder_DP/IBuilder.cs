using System;

namespace RefactoringGuru.DesignPatterns.Builder.Conceptual
{
    // Interface Builder định nghĩa các phương thức để tạo các phần khác nhau của Product.
    public interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        void BuildPartC();
    }
}