using NLog;
using System;
using LeetCode.Backtracking;
using LeetCode.Config;
using LeetCode.DynamicProgramming;
using LeetCode.Models;
using LeetCode.TreesAndGraphs;
using Microsoft.Extensions.DependencyInjection;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {   
            var target = DependencyServicesProvider.Get().GetService<IMinimumWindowSubSequence>();
            var node = target.MinWindow("abcdebdde", "bde");
            
            Console.WriteLine("Hello World!");
        }

        private static ILogger Logger = LogManager.GetCurrentClassLogger();
    }
}