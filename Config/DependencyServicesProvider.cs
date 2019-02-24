using System;
using LeetCode.Backtracking;
using LeetCode.TreesAndGraphs;
using LeetCode.SortingAndSearching;
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

            serviceCollection.TryAddSingleton<IPhonenumber, PhoneNumber>();
            serviceCollection.TryAddSingleton<IPermutations, Permutations>();
            serviceCollection.TryAddSingleton<IMeetingRooms, MeetingRooms>();
            serviceCollection.TryAddSingleton<IPermutations2, Permutations2>();
            serviceCollection.TryAddSingleton<ICombinationSum, CombinationSum>();
            serviceCollection.TryAddSingleton<INumberOfIslands, NumberOfIslands>();
            serviceCollection.TryAddSingleton<ISubSetsGenerator, SubSetsGenerator>();
            serviceCollection.TryAddSingleton<IRotatedSortedArray, RotatedSortedArray>();
            serviceCollection.TryAddSingleton<IRotatedSortedArray2, RotatedSortedArray2>();
            serviceCollection.TryAddSingleton<IBinaryTreeConstructor, BinaryTreeConstructor>();
            serviceCollection.TryAddSingleton<IDoublyLinkedListConverter, DoublyLinkedListConverter>();
            
            return serviceCollection;
        }
        private static IServiceProvider _serviceProvider;
    }
}