using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Hyhrobot.WebManagement.Configuration.Dto;

namespace Hyhrobot.WebManagement.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : WebManagementAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
