using System;
using System.Runtime.CompilerServices;

namespace Redux
{
    // ReSharper disable once InconsistentNaming
    public partial struct Index<T> :
     	IComparable<Index<T>>,        IEquatable<Index<T>>,        IFormattable
	{
		internal i32 _value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Index(i32 value)
		{
			_value = value;
		}


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator >(Index<T> left, Index<T> right)
		{
			return left._value > right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator <(Index<T> left, Index<T> right)
		{
			return left._value < right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator <=(Index<T> left, Index<T> right)
		{
			return left._value <= right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator >=(Index<T> left, Index<T> right)
		{
			return left._value >= right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int CompareTo(Index<T> other)
		{
			return _value.CompareTo(other._value);
		}

		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(Index<T> left, Index<T> right)
		{
			return left._value == right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(Index<T> left, Index<T> right)
		{
			return left._value != right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(Index<T> right)
		{
			return this == right;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override bool Equals(object obj)
		{
			var other = obj as Index<T>?;
			return other.HasValue && Equals(other.Value);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode()
		{
			return _value.GetHashCode();
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return _value.ToString(format, formatProvider);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override string ToString()
		{
			return _value.ToString();
		}
    }

    // ReSharper disable once InconsistentNaming
    public partial struct Count<T> :
     	IComparable<Count<T>>,        IEquatable<Count<T>>,        IFormattable
	{
		internal i32 _value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Count(i32 value)
		{
			_value = value;
		}


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator >(Count<T> left, Count<T> right)
		{
			return left._value > right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator <(Count<T> left, Count<T> right)
		{
			return left._value < right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator <=(Count<T> left, Count<T> right)
		{
			return left._value <= right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator >=(Count<T> left, Count<T> right)
		{
			return left._value >= right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int CompareTo(Count<T> other)
		{
			return _value.CompareTo(other._value);
		}

		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(Count<T> left, Count<T> right)
		{
			return left._value == right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(Count<T> left, Count<T> right)
		{
			return left._value != right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(Count<T> right)
		{
			return this == right;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override bool Equals(object obj)
		{
			var other = obj as Count<T>?;
			return other.HasValue && Equals(other.Value);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode()
		{
			return _value.GetHashCode();
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return _value.ToString(format, formatProvider);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override string ToString()
		{
			return _value.ToString();
		}
    }

    // ReSharper disable once InconsistentNaming
    public partial struct i8 :
     	IComparable<i8>,        IEquatable<i8>,        IFormattable
	{
		internal sbyte _value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public i8(sbyte value)
		{
			_value = value;
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator i8(sbyte value)
		{
			return new i8(value);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator sbyte (i8 value)
		{
			return value._value;
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator >(i8 left, i8 right)
		{
			return left._value > right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator <(i8 left, i8 right)
		{
			return left._value < right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator <=(i8 left, i8 right)
		{
			return left._value <= right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator >=(i8 left, i8 right)
		{
			return left._value >= right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int CompareTo(i8 other)
		{
			return _value.CompareTo(other._value);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static i8 operator <<(i8 left, int right)
		{
			return (sbyte)(left._value << right);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static i8 operator >>(i8 left, int right)
		{
			return (sbyte)(left._value >> right);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(i8 left, i8 right)
		{
			return left._value == right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(i8 left, i8 right)
		{
			return left._value != right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(i8 right)
		{
			return this == right;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override bool Equals(object obj)
		{
			var other = obj as i8?;
			return other.HasValue && Equals(other.Value);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode()
		{
			return _value.GetHashCode();
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return _value.ToString(format, formatProvider);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override string ToString()
		{
			return _value.ToString();
		}
    }

    // ReSharper disable once InconsistentNaming
    public partial struct u8 :
     	IComparable<u8>,        IEquatable<u8>,        IFormattable
	{
		internal byte _value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public u8(byte value)
		{
			_value = value;
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator u8(byte value)
		{
			return new u8(value);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator byte (u8 value)
		{
			return value._value;
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator >(u8 left, u8 right)
		{
			return left._value > right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator <(u8 left, u8 right)
		{
			return left._value < right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator <=(u8 left, u8 right)
		{
			return left._value <= right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator >=(u8 left, u8 right)
		{
			return left._value >= right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int CompareTo(u8 other)
		{
			return _value.CompareTo(other._value);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static u8 operator <<(u8 left, int right)
		{
			return (byte)(left._value << right);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static u8 operator >>(u8 left, int right)
		{
			return (byte)(left._value >> right);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(u8 left, u8 right)
		{
			return left._value == right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(u8 left, u8 right)
		{
			return left._value != right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(u8 right)
		{
			return this == right;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override bool Equals(object obj)
		{
			var other = obj as u8?;
			return other.HasValue && Equals(other.Value);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode()
		{
			return _value.GetHashCode();
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return _value.ToString(format, formatProvider);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override string ToString()
		{
			return _value.ToString();
		}
    }

    // ReSharper disable once InconsistentNaming
    public partial struct i16 :
     	IComparable<i16>,        IEquatable<i16>,        IFormattable
	{
		internal short _value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public i16(short value)
		{
			_value = value;
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator i16(short value)
		{
			return new i16(value);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator short (i16 value)
		{
			return value._value;
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator >(i16 left, i16 right)
		{
			return left._value > right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator <(i16 left, i16 right)
		{
			return left._value < right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator <=(i16 left, i16 right)
		{
			return left._value <= right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator >=(i16 left, i16 right)
		{
			return left._value >= right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int CompareTo(i16 other)
		{
			return _value.CompareTo(other._value);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static i16 operator <<(i16 left, int right)
		{
			return (short)(left._value << right);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static i16 operator >>(i16 left, int right)
		{
			return (short)(left._value >> right);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(i16 left, i16 right)
		{
			return left._value == right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(i16 left, i16 right)
		{
			return left._value != right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(i16 right)
		{
			return this == right;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override bool Equals(object obj)
		{
			var other = obj as i16?;
			return other.HasValue && Equals(other.Value);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode()
		{
			return _value.GetHashCode();
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return _value.ToString(format, formatProvider);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override string ToString()
		{
			return _value.ToString();
		}
    }

    // ReSharper disable once InconsistentNaming
    public partial struct u16 :
     	IComparable<u16>,        IEquatable<u16>,        IFormattable
	{
		internal ushort _value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public u16(ushort value)
		{
			_value = value;
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator u16(ushort value)
		{
			return new u16(value);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator ushort (u16 value)
		{
			return value._value;
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator >(u16 left, u16 right)
		{
			return left._value > right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator <(u16 left, u16 right)
		{
			return left._value < right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator <=(u16 left, u16 right)
		{
			return left._value <= right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator >=(u16 left, u16 right)
		{
			return left._value >= right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int CompareTo(u16 other)
		{
			return _value.CompareTo(other._value);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static u16 operator <<(u16 left, int right)
		{
			return (ushort)(left._value << right);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static u16 operator >>(u16 left, int right)
		{
			return (ushort)(left._value >> right);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(u16 left, u16 right)
		{
			return left._value == right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(u16 left, u16 right)
		{
			return left._value != right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(u16 right)
		{
			return this == right;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override bool Equals(object obj)
		{
			var other = obj as u16?;
			return other.HasValue && Equals(other.Value);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode()
		{
			return _value.GetHashCode();
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return _value.ToString(format, formatProvider);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override string ToString()
		{
			return _value.ToString();
		}
    }

    // ReSharper disable once InconsistentNaming
    public partial struct i32 :
     	IComparable<i32>,        IEquatable<i32>,        IFormattable
	{
		internal int _value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public i32(int value)
		{
			_value = value;
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator i32(int value)
		{
			return new i32(value);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator int (i32 value)
		{
			return value._value;
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator >(i32 left, i32 right)
		{
			return left._value > right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator <(i32 left, i32 right)
		{
			return left._value < right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator <=(i32 left, i32 right)
		{
			return left._value <= right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator >=(i32 left, i32 right)
		{
			return left._value >= right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int CompareTo(i32 other)
		{
			return _value.CompareTo(other._value);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static i32 operator <<(i32 left, int right)
		{
			return (int)(left._value << right);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static i32 operator >>(i32 left, int right)
		{
			return (int)(left._value >> right);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(i32 left, i32 right)
		{
			return left._value == right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(i32 left, i32 right)
		{
			return left._value != right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(i32 right)
		{
			return this == right;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override bool Equals(object obj)
		{
			var other = obj as i32?;
			return other.HasValue && Equals(other.Value);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode()
		{
			return _value.GetHashCode();
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return _value.ToString(format, formatProvider);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override string ToString()
		{
			return _value.ToString();
		}
    }

    // ReSharper disable once InconsistentNaming
    public partial struct u32 :
     	IComparable<u32>,        IEquatable<u32>,        IFormattable
	{
		internal uint _value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public u32(uint value)
		{
			_value = value;
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator u32(uint value)
		{
			return new u32(value);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator uint (u32 value)
		{
			return value._value;
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator >(u32 left, u32 right)
		{
			return left._value > right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator <(u32 left, u32 right)
		{
			return left._value < right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator <=(u32 left, u32 right)
		{
			return left._value <= right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator >=(u32 left, u32 right)
		{
			return left._value >= right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int CompareTo(u32 other)
		{
			return _value.CompareTo(other._value);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static u32 operator <<(u32 left, int right)
		{
			return (uint)(left._value << right);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static u32 operator >>(u32 left, int right)
		{
			return (uint)(left._value >> right);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(u32 left, u32 right)
		{
			return left._value == right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(u32 left, u32 right)
		{
			return left._value != right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(u32 right)
		{
			return this == right;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override bool Equals(object obj)
		{
			var other = obj as u32?;
			return other.HasValue && Equals(other.Value);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode()
		{
			return _value.GetHashCode();
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return _value.ToString(format, formatProvider);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override string ToString()
		{
			return _value.ToString();
		}
    }

    // ReSharper disable once InconsistentNaming
    public partial struct i64 :
     	IComparable<i64>,        IEquatable<i64>,        IFormattable
	{
		internal long _value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public i64(long value)
		{
			_value = value;
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator i64(long value)
		{
			return new i64(value);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator long (i64 value)
		{
			return value._value;
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator >(i64 left, i64 right)
		{
			return left._value > right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator <(i64 left, i64 right)
		{
			return left._value < right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator <=(i64 left, i64 right)
		{
			return left._value <= right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator >=(i64 left, i64 right)
		{
			return left._value >= right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int CompareTo(i64 other)
		{
			return _value.CompareTo(other._value);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static i64 operator <<(i64 left, int right)
		{
			return (long)(left._value << right);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static i64 operator >>(i64 left, int right)
		{
			return (long)(left._value >> right);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(i64 left, i64 right)
		{
			return left._value == right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(i64 left, i64 right)
		{
			return left._value != right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(i64 right)
		{
			return this == right;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override bool Equals(object obj)
		{
			var other = obj as i64?;
			return other.HasValue && Equals(other.Value);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode()
		{
			return _value.GetHashCode();
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return _value.ToString(format, formatProvider);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override string ToString()
		{
			return _value.ToString();
		}
    }

    // ReSharper disable once InconsistentNaming
    public partial struct u64 :
     	IComparable<u64>,        IEquatable<u64>,        IFormattable
	{
		internal ulong _value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public u64(ulong value)
		{
			_value = value;
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator u64(ulong value)
		{
			return new u64(value);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator ulong (u64 value)
		{
			return value._value;
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator >(u64 left, u64 right)
		{
			return left._value > right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator <(u64 left, u64 right)
		{
			return left._value < right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator <=(u64 left, u64 right)
		{
			return left._value <= right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator >=(u64 left, u64 right)
		{
			return left._value >= right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int CompareTo(u64 other)
		{
			return _value.CompareTo(other._value);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static u64 operator <<(u64 left, int right)
		{
			return (ulong)(left._value << right);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static u64 operator >>(u64 left, int right)
		{
			return (ulong)(left._value >> right);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(u64 left, u64 right)
		{
			return left._value == right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(u64 left, u64 right)
		{
			return left._value != right._value;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(u64 right)
		{
			return this == right;
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override bool Equals(object obj)
		{
			var other = obj as u64?;
			return other.HasValue && Equals(other.Value);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode()
		{
			return _value.GetHashCode();
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return _value.ToString(format, formatProvider);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override string ToString()
		{
			return _value.ToString();
		}
    }

}
