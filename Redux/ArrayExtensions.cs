namespace Redux
{
    public static class ArrayExtensions
    {
        public static void CopyTo<T>(
            this Array<T> source,
            Array<T> destination,
            Index<T> destinationIndex,
            Index<T> index,
            Count<T> count)
        {
            for (var c = count.Zero; c < count; ++c)
            {
                destination[destinationIndex + c] = source[index + c];
            }
        }

        public static void CopyTo<T>(this Array<T> source, Array<T> destination)
        {
            source.CopyTo(destination, new Index<T>(0), new Index<T>(0), source.Length);
        }
    }
}