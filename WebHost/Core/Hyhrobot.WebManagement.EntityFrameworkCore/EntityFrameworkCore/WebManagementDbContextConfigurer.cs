using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Hyhrobot.WebManagement.EntityFrameworkCore
{
    public static class WebManagementDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<WebManagementDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<WebManagementDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
