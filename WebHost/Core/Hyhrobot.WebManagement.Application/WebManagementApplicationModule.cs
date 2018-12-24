using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Hyhrobot.WebManagement.Authorization;

namespace Hyhrobot.WebManagement
{
    [DependsOn(
        typeof(WebManagementCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class WebManagementApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<WebManagementAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(WebManagementApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);
            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
