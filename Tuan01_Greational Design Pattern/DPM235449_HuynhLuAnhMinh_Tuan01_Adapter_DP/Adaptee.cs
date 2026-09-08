namespace RefactoringGuru.DesignPatterns.Adapter.Conceptual
{
    // Class Adaptee chứa xử lý nghiệp vụ nhưng giao diện không tương thích trực tiếp với Client.
    class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific request.";
        }
    }
}