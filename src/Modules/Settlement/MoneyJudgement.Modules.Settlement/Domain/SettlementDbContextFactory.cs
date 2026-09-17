using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MoneyJudgement.Modules.Settlement.Domain
{
    public class SettlementDbContextFactory : IDesignTimeDbContextFactory<SettlementDbContext>
    {
        public SettlementDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SettlementDbContext>();
            optionsBuilder.UseNpgsql(
                "Host=localhost;Port=5433;Database=moneyjudgement;Username=moneyjudgement;Password=moneyjudgement",
                x => x.MigrationsHistoryTable("__EFMigrationsHistory", "settlement"));

            return new SettlementDbContext(optionsBuilder.Options);
        }
    }
}
