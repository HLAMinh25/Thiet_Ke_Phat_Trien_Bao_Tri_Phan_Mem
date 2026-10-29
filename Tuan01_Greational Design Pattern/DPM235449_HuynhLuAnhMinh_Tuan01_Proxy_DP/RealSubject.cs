using System;

namespace RefactoringGuru.DesignPatterns.Proxy.Conceptual
{
    // RealSubject chứa logic nghiệp vụ cốt lõi, xử lý yêu cầu thực tế.
    class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling Request.");
        }
    }
}