using System;
using LeetCode.ArraysAndStrings;
using LeetCode.Backtracking;
using LeetCode.DynamicProgramming;
using LeetCode.SortingAndSearching;
using LeetCode.TreesAndGraphs;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace LeetCode.Config
{
    public static class DependencyServicesProvider
    {
        public static IServiceProvider Get()
        {
            return _serviceProvider ?? (_serviceProvider = GetServiceCollection().AddLogging().BuildServiceProvider());
        }

        private static IServiceCollection GetServiceCollection()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.TryAddSingleton<ISum3, Sum3>();
            serviceCollection.TryAddSingleton<IDecodeWays, DecodeWays>();
            serviceCollection.TryAddSingleton<IPhonenumber, PhoneNumber>();
            serviceCollection.TryAddSingleton<IBuySellStock, BuySellStock>();
            serviceCollection.TryAddSingleton<IPermutations, Permutations>();
            serviceCollection.TryAddSingleton<IMeetingRooms, MeetingRooms>();
            serviceCollection.TryAddSingleton<IPermutations2, Permutations2>();          
            serviceCollection.TryAddSingleton<ICombinationSum, CombinationSum>();
            serviceCollection.TryAddSingleton<IMergeIntervals, MergeIntervals>();
            serviceCollection.TryAddSingleton<INumberOfIslands, NumberOfIslands>();
            serviceCollection.TryAddSingleton<IMinimumSubArray, MinimumSubArray>();
            serviceCollection.TryAddSingleton<ISubSetsGenerator, SubSetsGenerator>();
            serviceCollection.TryAddSingleton<IMergeSortedLists, MergeSortedLists>();
            serviceCollection.TryAddSingleton<IRotatedSortedArray, RotatedSortedArray>();
            serviceCollection.TryAddSingleton<IRotatedSortedArray2, RotatedSortedArray2>();
            serviceCollection.TryAddSingleton<IBinaryTreeConstructor, BinaryTreeConstructor>();
            serviceCollection.TryAddSingleton<IMinimumWindowSubSequence, MinimumWindowSubSequence>();
            serviceCollection.TryAddSingleton<IDoublyLinkedListConverter, DoublyLinkedListConverter>();
            
            return serviceCollection;
        }
        private static IServiceProvider _serviceProvider;
    }
}