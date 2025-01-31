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
    }
}
