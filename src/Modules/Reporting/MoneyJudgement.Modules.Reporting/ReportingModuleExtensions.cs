using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MoneyJudgement.Modules.Reporting.Domain;

namespace MoneyJudgement.Modules.Reporting
{
    public static class ReportingModuleExtensions
    {
        public static IServiceCollection AddReportingModule(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<ReportingDbContext>(options =>
                options.UseNpgsql(connectionString, npgsql =>
                {
                    npgsql.MigrationsHistoryTable("__EFMigrationsHistory", "reporting");
                }));

            return services;
        }
    }
}
