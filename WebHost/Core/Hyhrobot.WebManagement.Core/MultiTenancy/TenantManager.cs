using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using Hyhrobot.WebManagement.Authorization.Users;
using Hyhrobot.WebManagement.Editions;

namespace Hyhrobot.WebManagement.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
