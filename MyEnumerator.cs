using System.Collections;

namespace c_working
{
    public class MyEnumerator<T> : IEnumerator<T>
    {
        private int _position = -1;
        private readonly List<T> _items;

        public MyEnumerator(List<T> items)
        {
            _items = items;
        }

        public T Current
        {
            get
            {
                if (_position < 0 || _position >= _items.Count)
                    throw new InvalidOperationException();
                return _items[_position];
            }
        }

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            _position++;
            Console.Write(_position.ToString() + ". indexs object ");
            return (_position < _items.Count);
        }

        public void Reset()
        {
            _position = -1;
        }

        public void Dispose() { }
    }
}