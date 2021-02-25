using System;
using System.Collections.Generic;
using System.Text;
using Castle.DynamicProxy;
using Microsoft.Extensions.DependencyInjection;
using SYCore.CrossCuttingConcerns.Caching;
using SYCore.Utilities.Interceptors;
using SYCore.Utilities.IoC;

namespace SYCore.Aspects.Autofac.Caching
{
    public class CacheFlushAspect : MethodInterception
    {
        private ICacheManager _cacheManager;

        public CacheFlushAspect() => _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();

        protected override void OnSuccess(IInvocation invocation)
        {
            _cacheManager.Clear();
        }
    }
}
