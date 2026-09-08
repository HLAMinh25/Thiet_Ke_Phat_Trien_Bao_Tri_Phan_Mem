using System;

namespace RefactoringGuru.DesignPatterns.Builder.Conceptual
{
    // Lớp Director chịu trách nhiệm quản lý thứ tự các bước xây dựng.
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildMinimalViableProduct()
        {
            this._builder.BuildPartA();
        }

        public void BuildFullFeaturedProduct()
        {
            this._builder.BuildPartA();
            this._builder.BuildPartB();
            this._builder.BuildPartC();
        }
    }
}