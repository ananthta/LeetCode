using System;
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

            serviceCollection.TryAddSingleton<IBinaryTreeConstructor, BinaryTreeConstructor>();
            
            return serviceCollection;
        }
        private static IServiceProvider _serviceProvider;
    }
}