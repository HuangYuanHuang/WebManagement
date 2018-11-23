using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Hyhrobot.WebManagement.Configuration;
using Hyhrobot.WebManagement.Web;

namespace Hyhrobot.WebManagement.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class WebManagementDbContextFactory : IDesignTimeDbContextFactory<WebManagementDbContext>
    {
        public WebManagementDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<WebManagementDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            WebManagementDbContextConfigurer.Configure(builder, configuration.GetConnectionString(WebManagementConsts.ConnectionStringName));

            return new WebManagementDbContext(builder.Options);
        }
    }
}
