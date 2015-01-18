using System;

namespace Redux
{
    public static class PrimitiveExtensions
    {
        public static T Min<T>(this T left, T right)
            where T : IComparable<T>
        {
            if (left.CompareTo(right) <= 0)
            {
                return left;
            }

            return right;
        }
        public static T Max<T>(this T left, T right)
            where T : IComparable<T>
        {
            if (left.CompareTo(right) >= 0)
            {
                return left;
            }

            return right;
        }
    }
}