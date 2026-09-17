using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MoneyJudgement.Modules.Reporting.Domain
{
    public class ReportingDbContextFactory : IDesignTimeDbContextFactory<ReportingDbContext>
    {
        public ReportingDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ReportingDbContext>();
            optionsBuilder.UseNpgsql(
                "Host=localhost;Port=5433;Database=moneyjudgement;Username=moneyjudgement;Password=moneyjudgement",
                x => x.MigrationsHistoryTable("__EFMigrationsHistory", "reporting"));

            return new ReportingDbContext(optionsBuilder.Options);
        }
    }
}
