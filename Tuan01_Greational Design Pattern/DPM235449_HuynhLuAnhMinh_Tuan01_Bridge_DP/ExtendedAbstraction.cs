namespace RefactoringGuru.DesignPatterns.Bridge.Conceptual
{
    // Lớp Abstraction mở rộng tính năng mà không can thiệp vào lớp Implementation.
    class ExtendedAbstraction : Abstraction
    {
        public ExtendedAbstraction(IImplementation implementation) : base(implementation)
        {
        }

        public override string Operation()
        {
            return "ExtendedAbstraction: Extended operation with:\n" +
                base._implementation.OperationImplementation();
        }
    }
}