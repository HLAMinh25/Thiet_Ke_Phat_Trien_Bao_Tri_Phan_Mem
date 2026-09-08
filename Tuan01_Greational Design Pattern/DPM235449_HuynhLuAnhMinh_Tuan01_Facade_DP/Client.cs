using System;

namespace RefactoringGuru.DesignPatterns.Facade.Conceptual
{
    // Client tương tác với hệ thống phức tạp thông qua giao diện đơn giản của Facade.
    class Client
    {
        public static void ClientCode(Facade facade)
        {
            Console.Write(facade.Operation());
        }
    }
}