namespace RefactoringGuru.DesignPatterns.Decorator.Conceptual
{
    // Cung cấp cài đặt mặc định cho Component.
    class ConcreteComponent : Component
    {
        public override string Operation()
        {
            return "ConcreteComponent";
        }
    }
}