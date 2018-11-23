using Abp.MultiTenancy;
using Hyhrobot.WebManagement.Authorization.Users;

namespace Hyhrobot.WebManagement.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
