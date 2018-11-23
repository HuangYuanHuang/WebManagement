using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Hyhrobot.WebManagement.Configuration;

namespace Hyhrobot.WebManagement.Web.Host.Startup
{
    [DependsOn(
       typeof(WebManagementWebCoreModule))]
    public class WebManagementWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public WebManagementWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(WebManagementWebHostModule).GetAssembly());
        }
    }
}
