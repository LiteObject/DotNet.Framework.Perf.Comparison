using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Framework.Perf.Comparison
{
    internal class Config : ManualConfig
    {
        public Config()
        {
            // AddJob(Job.Default.WithRuntime(CoreRuntime.Core50));            
        }
    }
}
