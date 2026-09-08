using System;

namespace RefactoringGuru.DesignPatterns.Composite.Conceptual
{
    // Lớp Client làm việc với các thành phần thông qua giao diện Component cơ sở.
    class Client
    {
        public void ClientCode(Component leaf)
        {
            Console.WriteLine($"RESULT: {leaf.Operation()}\n");
        }

        public void ClientCode2(Component component1, Component component2)
        {
            if (component1.IsComposite())
            {
                component1.Add(component2);
            }

            Console.WriteLine($"RESULT: {component1.Operation()}");
        }
    }
}