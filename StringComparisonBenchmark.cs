using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace DotNet.Framework.Perf.Comparison
{
    [MemoryDiagnoser]
    // [SimpleJob(RuntimeMoniker.Net48, baseline: true)]
    // [SimpleJob(RuntimeMoniker.Net90, baseline: false)]
    public class StringComparisonBenchmark
    {
        private const string String1 = "Hello";
        private const string String2 = "World";
        private const string LongString = "Hello World! This is a longer sample string to test string operations.";

        [Benchmark]
        public bool EqualsMethod()
        {
            return String1.Equals(String2);
        }

        [Benchmark]
        public int CompareToMethod()
        {
            return String1.CompareTo(String2);
        }

        [Benchmark]
        public string ConcatMethod()
        {
            return string.Concat(String1, String2);
        }

        [Benchmark]
        public string SubstringMethod()
        {
            return LongString.Substring(6, 5); // "World"
        }

        [Benchmark]
        public string ReplaceMethod()
        {
            return LongString.Replace("Hello", "Hi");
        }

        [Benchmark]
        public bool StartsWithMethod()
        {
            return LongString.StartsWith("Hello");
        }

        [Benchmark]
        public bool EndsWithMethod()
        {
            return LongString.EndsWith("operations.");
        }

        [Benchmark]
        public string ToUpperMethod()
        {
            return LongString.ToUpper();
        }

        [Benchmark]
        public string ToLowerMethod()
        {
            return LongString.ToLower();
        }

        [Benchmark]
        public int IndexOfMethod()
        {
            return LongString.IndexOf("sample");
        }

        [Benchmark]
        public string RemoveMethod()
        {
            return LongString.Remove(12, 5); // Remove "World"
        }
    }
}
