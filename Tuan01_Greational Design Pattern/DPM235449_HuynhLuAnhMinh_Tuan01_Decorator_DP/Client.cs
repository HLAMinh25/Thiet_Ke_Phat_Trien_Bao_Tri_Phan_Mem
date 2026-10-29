using System;

namespace RefactoringGuru.DesignPatterns.Decorator.Conceptual
{
    public class Client
    {
        public void ClientCode(Component component)
        {
            Console.WriteLine("RESULT: " + component.Operation());
        }
    }
}