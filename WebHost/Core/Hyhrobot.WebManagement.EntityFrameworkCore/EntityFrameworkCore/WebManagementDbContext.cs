using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Hyhrobot.WebManagement.Authorization.Roles;
using Hyhrobot.WebManagement.Authorization.Users;
using Hyhrobot.WebManagement.MultiTenancy;

namespace Hyhrobot.WebManagement.EntityFrameworkCore
{
    public class WebManagementDbContext : AbpZeroDbContext<Tenant, Role, User, WebManagementDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public WebManagementDbContext(DbContextOptions<WebManagementDbContext> options)
            : base(options)
        {
        }
    }
}
