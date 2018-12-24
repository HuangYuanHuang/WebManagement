using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Hyhrobot.WebManagement.EntityFrameworkCore
{
    public static class WebManagementDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<WebManagementDbContext> builder, string connectionString)
        {
           // builder.UseSqlServer(connectionString);
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<WebManagementDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);

           // builder.UseSqlServer(connection);
        }
    }
}
