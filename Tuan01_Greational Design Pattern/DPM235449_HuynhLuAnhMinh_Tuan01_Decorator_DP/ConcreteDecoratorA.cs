namespace RefactoringGuru.DesignPatterns.Decorator.Conceptual
{
    // Decorator cụ thể A thêm hành vi hoặc biến đổi kết quả của đối tượng bên trong.
    class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component comp) : base(comp)
        {
        }

        public override string Operation()
        {
            return $"ConcreteDecoratorA({base.Operation()})";
        }
    }
}