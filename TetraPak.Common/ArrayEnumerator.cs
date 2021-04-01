using System.Collections;
using System.Collections.Generic;

namespace TetraPak
{
    public class ArrayEnumerator<T> : IEnumerator<T>
    {
        int _index;
        readonly T[] _items;
        
        public bool MoveNext()
        {
            if (_index == _items.Length-1)
                return false;

            ++_index;
            return true;
        }

        bool IsInsideRange => _index >= 0 && _index < _items.Length;

        public void Reset()
        {
            _index = -1;
        }

        public T Current => IsInsideRange ? _items[_index] : default;

        object IEnumerator.Current => Current;

        public ArrayEnumerator(T[] items)
        {
            _items = items;
            Reset();
        }

        public void Dispose()
        {
        }
    }
}