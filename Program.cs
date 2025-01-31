using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using System;

namespace DotNet.Framework.Perf.Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = DefaultConfig.Instance
                .AddJob(Job.Default.WithRuntime(ClrRuntime.Net48))
                .AddJob(Job.Default.WithRuntime(CoreRuntime.Core90));                

            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args, config);

            // Run the benchmark for both target frameworks
            //if (args.Length > 0 && args[0] == "net9.0")
            //{
            //    Console.WriteLine("Running benchmarks on .NET 9");
            //    BenchmarkRunner.Run<StringComparisonBenchmark>();
            //}
            //else if (args.Length > 0 && args[0] == "net48")
            //{
            //    Console.WriteLine("Running benchmarks on .NET Framework 4.8");
            //    BenchmarkRunner.Run<StringComparisonBenchmark>();
            //}
        }
    }
}
