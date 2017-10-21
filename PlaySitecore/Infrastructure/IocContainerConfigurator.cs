using Sitecore.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Extensions.DependencyInjection;
using Glass.Mapper.Sc;

namespace PlaySitecore.Infrastructure
{
    public class IocContainerConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(ISitecoreContext), typeof(SitecoreContext));
            serviceCollection.AddMvcControllers("PlaySitecore");
        }
    }
}