namespace RefactoringGuru.DesignPatterns.Facade.Conceptual
{
    // Subsystem1 cung cấp các chức năng chi tiết của hệ thống con thứ nhất.
    public class Subsystem1
    {
        public string operation1()
        {
            return "Subsystem1: Ready!\n";
        }

        public string operationN()
        {
            return "Subsystem1: Go!\n";
        }
    }
}