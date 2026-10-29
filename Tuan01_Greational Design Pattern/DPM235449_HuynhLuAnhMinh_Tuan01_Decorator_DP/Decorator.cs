namespace RefactoringGuru.DesignPatterns.Decorator.Conceptual
{
    // Lớp cơ sở Decorator kế thừa Component và chứa một tham chiếu đến Component được bọc (wrapped).
    abstract class Decorator : Component
    {
        protected Component _component;

        public Decorator(Component component)
        {
            this._component = component;
        }

        public void SetComponent(Component component)
        {
            this._component = component;
        }

        public override string Operation()
        {
            if (this._component != null)
            {
                return this._component.Operation();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}