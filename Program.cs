using NLog;
using System;
using LeetCode.Backtracking;
using LeetCode.Config;
using LeetCode.Models;
using LeetCode.TreesAndGraphs;
using Microsoft.Extensions.DependencyInjection;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {   
            var target = DependencyServicesProvider.Get().GetService<IPermutations2>();
            var node = target.PermuteUnique(new int[]{1, 1, 2});
            
            Console.WriteLine("Hello World!");
        }

        private static ILogger Logger = LogManager.GetCurrentClassLogger();
    }
}