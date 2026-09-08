namespace RefactoringGuru.DesignPatterns.AbstractFactory.Conceptual
{
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();
    }
}