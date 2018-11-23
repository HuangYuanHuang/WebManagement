using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Hyhrobot.WebManagement.MultiTenancy.Dto;

namespace Hyhrobot.WebManagement.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
