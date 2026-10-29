namespace RefactoringGuru.DesignPatterns.Proxy.Conceptual
{
    // Client tương tác với tất cả các đối tượng thông qua giao diện ISubject.
    public class Client
    {
        public void ClientCode(ISubject subject)
        {
            subject.Request();
        }
    }
}