using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SYCore.CrossCuttingConcerns.Caching;
using SYCore.CrossCuttingConcerns.Caching.Redis;
using SYCore.Utilities.IoC;

namespace SYCore.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        private IConfiguration _configuration;

        public CoreModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Load(IServiceCollection services)
        {
            services.AddSingleton<ICacheManager, RedisCacheManager>();
            services.AddSingleton<Stopwatch>();
        }
    }
}
