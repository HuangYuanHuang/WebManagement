using System.Threading.Tasks;
using Abp.Application.Services;
using Hyhrobot.WebManagement.Authorization.Accounts.Dto;

namespace Hyhrobot.WebManagement.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
