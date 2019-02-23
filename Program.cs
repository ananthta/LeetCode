using NLog;
using System;
using LeetCode.Backtracking;
using LeetCode.Config;
using LeetCode.Models;
using LeetCode.SortingAndSearching;
using LeetCode.TreesAndGraphs;
using Microsoft.Extensions.DependencyInjection;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {   
            var target = DependencyServicesProvider.Get().GetService<IMeetingRooms>();
            var rooms = target.MinMeetingRooms(new Interval[]
                {new Interval(7, 10), new Interval(2, 4)});
            
            Console.WriteLine("Hello World!");
        }

        private static ILogger Logger = LogManager.GetCurrentClassLogger();
    }
}