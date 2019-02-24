using NLog;
using System;
using System.Collections.Generic;
using LeetCode.Config;
using LeetCode.Models;
using LeetCode.SortingAndSearching;
using Microsoft.Extensions.DependencyInjection;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {   
            var target = DependencyServicesProvider.Get().GetService<IMergeIntervals>();
            var rooms = target.Merge(new List<Interval>{new Interval(1,4), new Interval(4,5)});
            
            Console.WriteLine("Hello World!");
        }

        private static ILogger Logger = LogManager.GetCurrentClassLogger();
    }
}