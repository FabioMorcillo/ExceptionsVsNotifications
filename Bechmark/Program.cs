using System;

using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace Bechmark
{
    class Program
    {
        static void Main(string[] args)
        {
            //IConfig config = ManualConfig.Create(DefaultConfig.Instance).WithOptions(ConfigOptions.DisableOptimizationsValidator);

            //var summary = BenchmarkRunner.Run<MemoryBenchmarkerDemo>(config);

            var summary = BenchmarkRunner.Run<MemoryBenchmarkerDemo>();

            var reports = summary.Reports;
            var table = summary.Table;
            
            Console.ReadLine();
        }
    }
}
