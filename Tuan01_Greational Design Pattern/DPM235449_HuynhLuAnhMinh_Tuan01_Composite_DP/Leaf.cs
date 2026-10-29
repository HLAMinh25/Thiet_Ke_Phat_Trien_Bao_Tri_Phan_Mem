namespace RefactoringGuru.DesignPatterns.Composite.Conceptual
{
    // Lớp Leaf đại diện cho các đối tượng lá (không có con).
    class Leaf : Component
    {
        public override string Operation()
        {
            return "Leaf";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}