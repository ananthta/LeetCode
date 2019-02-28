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
            var target = DependencyServicesProvider.Get().GetService<IRainWaterTrap>();
            var node = target.Trap(new int[] {0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1});
            
            Console.WriteLine("Hello World!");
        }

        private static ILogger Logger = LogManager.GetCurrentClassLogger();
    }
}