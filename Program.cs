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
            var target = DependencyServicesProvider.Get().GetService<ISum3>();
            var node = target.ThreeSum(new int[]{-2, 0, 1, 1, 2});
            
            Console.WriteLine("Hello World!");
        }

        private static ILogger Logger = LogManager.GetCurrentClassLogger();
    }
}