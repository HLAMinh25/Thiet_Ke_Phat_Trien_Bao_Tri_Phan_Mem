namespace RefactoringGuru.DesignPatterns.Bridge.Conceptual
{
    // Abstraction đóng vai trò điều khiển, giữ tham chiếu đến IImplementation.
    class Abstraction
    {
        protected IImplementation _implementation;

        public Abstraction(IImplementation implementation)
        {
            this._implementation = implementation;
        }

        public virtual string Operation()
        {
            return "Abstract: Base operation with:\n" +
                _implementation.OperationImplementation();
        }
    }
}