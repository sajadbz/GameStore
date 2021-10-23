using GameStore.Core.Services.Implementations;
using GameStore.Core.Services.Interfaces;
using GameStore.Data.Repositories;
using GameStore.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace GameStore.IoC
{
    public class Container
    {
        private static ServiceCollection _services;
        private static ServiceProvider ServiceProvider;

        public ServiceProvider Register(ServiceCollection services = null)
        {
            if (_services == null)
                _services = new ServiceCollection();

            if (services != null)
                _services = services;

            ConfigureServices(_services);
            ServiceProvider = _services.BuildServiceProvider();

            return ServiceProvider;
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services                
                .AddScoped<IGameRepository, GameRepository>()
                .AddScoped<IGameService, GameService>()
                .AddScoped<IGameGroupRepository, GameGroupRepository>()
                .AddScoped<IGameGroupService, GameGroupService>();
        }
    }
}
