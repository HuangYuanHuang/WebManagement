using System.Threading.Tasks;
using Hyhrobot.WebManagement.Configuration.Dto;

namespace Hyhrobot.WebManagement.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
