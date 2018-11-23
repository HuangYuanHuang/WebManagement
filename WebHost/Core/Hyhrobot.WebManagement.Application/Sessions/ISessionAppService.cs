using System.Threading.Tasks;
using Abp.Application.Services;
using Hyhrobot.WebManagement.Sessions.Dto;

namespace Hyhrobot.WebManagement.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
