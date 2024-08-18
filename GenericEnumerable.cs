using System.Collections;

namespace c_working;

public class GenericEnumerable<T> : IEnumerable<T> where T : class
{
    private List<T> list = new List<T>();

    public void Add(T module){

        list.Add(module);
    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        return new MyEnumerator<T>(list);
    }
}
