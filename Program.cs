using NLog;
using System;
using LeetCode.Config;
using LeetCode.SortingAndSearching;
using Microsoft.Extensions.DependencyInjection;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {   
            var target = DependencyServicesProvider.Get().GetService<IRotatedSortedArray>();
            var rooms = target.Search(new []{2,5,6,0,0,1,2}, 0);
            
            Console.WriteLine("Hello World!");
        }

        private static ILogger Logger = LogManager.GetCurrentClassLogger();
    }
}