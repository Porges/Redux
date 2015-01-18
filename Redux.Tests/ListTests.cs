using System;
using System.Diagnostics;
using Xunit;

namespace Redux.Tests
{
    public class ListTests
    {
        [Fact]
        public void InitialCountIsZero()
        {
            var l = new List<i32>();
            Assert.Equal(l.Count, new Count<i32>(0));
        }

        [Fact]
        public void CannotAccessEmptyList()
        {
            var l = new List<i32>();
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => l[l.FirstIndex]);

            Assert.Equal("index", ex.ParamName);
        }

        [Fact]
        public void AddingAddsCorrectValue()
        {
            var l = new List<i32>();
            l.Add(1);

            Assert.Equal(l[l.FirstIndex], new i32(1));
        }

        [Fact]
        public void AddingIncrementsCount()
        {
            var l = new List<i32>();
            l.Add(1);

            Assert.Equal(new Count<i32>(1), l.Count);
        }

        [Fact]
        public void AddingManyAddsValues()
        {
            var numberToAdd = new Count<i32>(33);
            i32 value = 10;

            var l = new List<i32>();
            l.Add(value, numberToAdd);

            for (var i = l.FirstIndex; i <= l.LastIndex; ++i)
            {
                Assert.Equal(value, l[i]);
            }
        }

        [Fact]
        public void AddingManyIncrementsValueCorrectly()
        {
            var numberToAdd = new Count<i32>(24);

            var l = new List<i32>();
            l.Add(10, numberToAdd);

            Assert.Equal(numberToAdd, l.Count);
        }

        [Fact]
        public void PerfTest()
        {
            Debug.Listeners.Add(new DefaultTraceListener());

            var sw1 = new Stopwatch();
            var sw2 = new Stopwatch();

            var iterations = new Count<i32>(1000);
            var inner = new Count<i32>(1000);

            for (var c = iterations.Zero; c < iterations; ++c)
            {
                {
                    sw1.Start();
                    var l = new System.Collections.Generic.List<i32>((int)inner);
                    for (var c2 = inner.Zero; c2 < inner; ++c2)
                    {
                        l.Add(0);
                    }
                    sw1.Stop();
                }

                {
                    sw2.Start();
                    var l = new List<i32>(inner);
                    for (var c2 = inner.Zero; c2 < inner; ++c2)
                    {
                        l.Add(0);
                    }
                    sw2.Stop();
                }
            }

            Assert.True(sw2.Elapsed < sw1.Elapsed, sw2.Elapsed + ">" + sw1.Elapsed);
        }
    }
}
