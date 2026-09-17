using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MoneyJudgement.Modules.BillSplitting.Domain;

namespace MoneyJudgement.Modules.BillSplitting
{
    public static class BillSplittingModuleExtensions
    {
        public static IServiceCollection AddBillSplittingModule(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<BillSplittingDbContext>(options =>
                options.UseNpgsql(connectionString, npgsql =>
                {
                    npgsql.MigrationsHistoryTable("__EFMigrationsHistory", "bill_splitting");
                }));

            return services;
        }
    }
}
