using System;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;

namespace Redux
{
    public class List<T>
    {
        private Array<T> _array;
        private Index<T> _next;
        private void RequireCount(Count<T> count)
        {
            var next = Count;
            var length = _array.Length;
            var available = length - next;
            if (available < count)
            {
                var newSize = (length * 4 / 3).Max(next + count);
                var newArray = new Array<T>(newSize);

                _array.CopyTo(newArray);
                _array = newArray;
            }
        }

        public List()
            : this(new Count<T>(10))
        {
        }

        public List(Count<T> capacity)
        {
            _array = new Array<T>(capacity);
        }

        public void Add(T value)
        {
            if (_next._value == _array.Length._value)
            {
                RequireCount(new Count<T>(1));
            }

            _array[_next++] = value;
        }

        public void Add(T value, Count<T> count)
        {
            if (count < count.Zero)
            {
                throw new ArgumentOutOfRangeException("count", count, "count must be >= 0");
            }

            RequireCount(count);

            for (var c = count.Zero; c < count; ++c)
            {
                _array[_next++] = value;
            }
        }

        public Index<T> FirstIndex => _next.Zero; // TODO: non-0 basis? >:D

        public Index<T> LastIndex => _next.Previous();  

        public Count<T> Count => _next - FirstIndex;

        public T this[Index<T> index]
        {
            get
            {
                if (index < index.Zero || index >= _next)
                {
                    throw new ArgumentOutOfRangeException("index", index, "index out of range");
                }

                return _array[index];
            }
        }
    }
}
