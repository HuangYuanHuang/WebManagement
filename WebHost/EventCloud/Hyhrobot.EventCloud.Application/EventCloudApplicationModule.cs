using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.AutoMapper;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Hyhrobot.EventCloud.Application.EventApi;
using Hyhrobot.WebManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hyhrobot.EventCloud.Application
{
    [DependsOn(
      typeof(WebManagementCoreModule),
      typeof(AbpAspNetCoreModule),
      typeof(AbpAutoMapperModule))]
    public class EventCloudApplicationModule : AbpModule
    {


        public override void Initialize()
        {
            var thisAssembly = typeof(EventCloudApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);
            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(EventCloudApplicationModule).GetAssembly()
                );
            //    DynamicApiControllerBuilder.For<IEventApplicationService>("tasksystem/task").Build();
            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
