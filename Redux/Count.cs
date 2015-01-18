using System.Reflection;
using System.Runtime.CompilerServices;

namespace Redux
{
    public partial struct Count<T>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Count<T> operator /(Count<T> left, i32 right)
        {
            return new Count<T>(left._value/right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Count<T> operator *(Count<T> left, i32 right)
        {
            return new Count<T>(left._value*right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Count<T> operator *(i32 left, Count<T> right)
        {
            return new Count<T>(left * right._value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Count<T> operator +(Count<T> left, Count<T> right)
        {
            return new Count<T>(left._value + right._value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Count<T> operator -(Count<T> left, Count<T> right)
        {
            return new Count<T>(left._value - right._value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Count<T> operator +(Count<T> left, i32 right)
        {
            return new Count<T>(left._value + right._value);
        }

        // Convenience method to get a 'zero' of the same type.
        public Count<T> Zero
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Count<T>(0); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Count<T> operator ++(Count<T> me)
        {
            ++me._value;
            return me;
        }
            
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator i32(Count<T> value)
        {
            return value._value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int(Count<T> value)
        {
            return value._value;
        }
    }
}
