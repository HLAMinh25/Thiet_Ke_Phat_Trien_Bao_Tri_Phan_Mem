namespace RefactoringGuru.DesignPatterns.AbstractFactory.Conceptual
{
    public interface IAbstractProductB
    {
        string UsefulFunctionB();
        string AnotherUsefulFunctionB(IAbstractProductA collaborator);
    }
}