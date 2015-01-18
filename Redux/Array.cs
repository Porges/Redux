namespace Redux
{
    public class Array<T>
    {
        private readonly T[] _array;

        public Array(Count<T> length)
        {
            _array = new T[(i32) length];
        }

        public T this[Index<T> index]
        {
            get { return _array[index._value]; }
            set { _array[index._value] = value; }
        }

        public Count<T> Length => new Count<T>(_array.Length);

        public static Array<T> Empty = new Array<T>(new Count<T>(0));
    }
}