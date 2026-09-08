namespace RefactoringGuru.DesignPatterns.Adapter.Conceptual
{
    // Adapter chuyển đổi giao diện của Adaptee thành giao diện ITarget.
    class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is '{this._adaptee.GetSpecificRequest()}'";
        }
    }
}