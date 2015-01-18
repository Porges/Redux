using System.Runtime.CompilerServices;

namespace Redux
{
    public partial struct Index<T>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Index<T> Next()
        {
            return new Index<T>(_value + 1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Index<T> Previous()
        {
            return new Index<T>(_value - 1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Count<T> operator -(Index<T> left, Index<T> right)
        {
            return new Count<T>(left._value - right._value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Index<T> operator +(Index<T> left, Count<T> right)
        {
            return new Index<T>(left._value + right._value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Index<T> operator -(Index<T> left, Count<T> right)
        {
            return new Index<T>(left._value - right._value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Count<T> operator -(Count<T> left, Index<T> right)
        {
            return new Count<T>(left._value - right._value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Index<T> operator ++(Index<T> me)
        {
            ++me._value;
            return me;
        }

        // Convenience method to get a 'zero' of the same type.
        public Index<T> Zero
        { 
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Index<T>(0); }
        }
            
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Index<T> operator +(Count<T> left, Index<T> right)
        {
            return new Index<T>(left._value + right._value);
        }
    }
}