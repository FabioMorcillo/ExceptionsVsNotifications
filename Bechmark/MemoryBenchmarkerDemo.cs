using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

using API;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Bechmark
{
    [InProcess]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [MemoryDiagnoser]
    [RankColumn]
    public class MemoryBenchmarkerDemo
    {
        private HttpClient _httpClient;

        [GlobalSetup]
        public void GlobalSetup()
        {
            var factory = new WebApplicationFactory<API.Startup>();

            _httpClient = factory.CreateClient();
        }

        int NumberOfItems = 1000;
        [Benchmark]
        public Task Exceptions()
        {
            //return _httpClient.GetAsync("exception");
            return _httpClient.GetAsync("exception");

            //for (var i = 0; i < NumberOfItems; ++i)
            //{
            //    try
            //    {
            //        throw new Exception("Error");
            //    }
            //    catch
            //    {

            //    }
            //}
        }

        [Benchmark(Baseline = true)]
        public Task Notifications()
        {
            return _httpClient.GetAsync("notification");

            //for (var i = 0; i < NumberOfItems; ++i)
            //{
            //    var list = new List<string>();

            //    list.Add("Error");
            //}
        }
    }
}
