using System;

namespace RefactoringGuru.DesignPatterns.Decorator.Conceptual
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            // Gọi Component đơn giản
            var simple = new ConcreteComponent();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(simple);
            Console.WriteLine();

            // Lồng ghép nhiều Decorator đè lên nhau
            ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
            ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
            Console.WriteLine("Client: Now I've got a decorated component:");
            client.ClientCode(decorator2);
        }
    }
}