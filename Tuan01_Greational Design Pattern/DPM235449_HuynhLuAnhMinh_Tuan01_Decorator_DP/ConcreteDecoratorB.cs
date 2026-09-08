namespace RefactoringGuru.DesignPatterns.Decorator.Conceptual
{
    // Decorator cụ thể B thêm một lớp xử lý khác xung quanh đối tượng.
    class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(Component comp) : base(comp)
        {
        }

        public override string Operation()
        {
            return $"ConcreteDecoratorB({base.Operation()})";
        }
    }
}