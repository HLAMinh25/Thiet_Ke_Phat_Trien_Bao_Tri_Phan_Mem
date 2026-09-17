using System.Collections;

namespace RefactoringGuru.DesignPatterns.Iterator.Conceptual
{
    abstract class IteratorAggregate : IEnumerable
    {
        // Returns an Iterator or another IteratorAggregate for the implementing
        // object.
        public abstract IEnumerator GetEnumerator();
    }
}