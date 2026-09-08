namespace RefactoringGuru.DesignPatterns.Bridge.Conceptual
{
    // Cung cấp xử lý cụ thể cho Platform B.
    class ConcreteImplementationB : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationB: The result in platform B.\n";
        }
    }
}