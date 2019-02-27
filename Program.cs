using NLog;
using System;
using LeetCode.ArraysAndStrings;
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
            var target = DependencyServicesProvider.Get().GetService<IMinimumSubArray>();
            var node = target.MinSubArrayLen(7, new int[]{2, 3, 1, 2, 4, 3});
            
            Console.WriteLine("Hello World!");
        }

        private static ILogger Logger = LogManager.GetCurrentClassLogger();
    }
}