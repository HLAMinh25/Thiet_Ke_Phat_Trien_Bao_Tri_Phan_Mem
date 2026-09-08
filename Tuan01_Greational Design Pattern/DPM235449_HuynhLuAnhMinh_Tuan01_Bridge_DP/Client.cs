using System;

namespace RefactoringGuru.DesignPatterns.Bridge.Conceptual
{
    class Client
    {
        public void ClientCode(Abstraction abstraction)
        {
            Console.Write(abstraction.Operation());
        }
    }
}