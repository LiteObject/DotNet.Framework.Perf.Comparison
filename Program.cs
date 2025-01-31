using BenchmarkDotNet.Columns;
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
                .AddLogicalGroupRules(BenchmarkLogicalGroupRule.ByMethod)
                .AddColumn(StatisticColumn.Mean, StatisticColumn.Median)
                .AddJob(Job.Default.WithRuntime(ClrRuntime.Net48))
                .AddJob(Job.Default.WithRuntime(CoreRuntime.Core90));                

            // BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args, config);
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args.Length > 0 ? args : new[] { "*" }, config);
        }
    }
}
