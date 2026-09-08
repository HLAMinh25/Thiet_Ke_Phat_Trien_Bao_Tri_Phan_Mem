namespace RefactoringGuru.DesignPatterns.Bridge.Conceptual
{
    // Cung cấp xử lý cụ thể cho Platform A.
    class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationA: The result in platform A.\n";
        }
    }
}