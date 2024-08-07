namespace Generics.Lab
{
    //where T : class
    //where T : struct
    //where T : Model
    //where T : Object
    //where T : IComparable
    //where T : ... 
    public class Generic
    { }

    public class Comparable<T> where T : IComparable
    {
        public T Max(T a, T b) =>
            a.CompareTo(b) > 0 ? a : b;

    }

    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {

        }
    }
}
