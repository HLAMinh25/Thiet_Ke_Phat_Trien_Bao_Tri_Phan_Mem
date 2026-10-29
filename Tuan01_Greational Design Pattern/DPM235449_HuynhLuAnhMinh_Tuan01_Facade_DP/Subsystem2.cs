namespace RefactoringGuru.DesignPatterns.Facade.Conceptual
{
    // Subsystem2 cung cấp các chức năng chi tiết của hệ thống con thứ hai.
    public class Subsystem2
    {
        public string operation1()
        {
            return "Subsystem2: Get ready!\n";
        }

        public string operationZ()
        {
            return "Subsystem2: Fire!\n";
        }
    }
}