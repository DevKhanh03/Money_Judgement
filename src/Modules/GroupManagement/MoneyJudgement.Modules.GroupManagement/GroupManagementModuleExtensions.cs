using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MoneyJudgement.Modules.GroupManagement.Domain;

namespace MoneyJudgement.Modules.GroupManagement
{
    public static class GroupManagementModuleExtensions
    {
        public static IServiceCollection AddGroupManagementModule(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<GroupManagementDbContext>(options =>
                options.UseNpgsql(connectionString, npgsql =>
                {
                    npgsql.MigrationsHistoryTable("__EFMigrationsHistory", "group_management");
                }));

            return services;
        }
    }
}
