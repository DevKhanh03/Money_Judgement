using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MoneyJudgement.Modules.Settlement.Domain;

namespace MoneyJudgement.Modules.Settlement
{
    public static class SettlementModuleExtensions
    {
        public static IServiceCollection AddSettlementModule(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<SettlementDbContext>(options =>
                options.UseNpgsql(connectionString, npgsql =>
                {
                    npgsql.MigrationsHistoryTable("__EFMigrationsHistory", "settlement");
                }));

            return services;
        }
    }
}
