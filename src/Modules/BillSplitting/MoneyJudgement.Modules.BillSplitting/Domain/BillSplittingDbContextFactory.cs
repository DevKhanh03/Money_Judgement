using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MoneyJudgement.Modules.BillSplitting.Domain
{
    public class BillSplittingDbContextFactory : IDesignTimeDbContextFactory<BillSplittingDbContext>
    {
        public BillSplittingDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BillSplittingDbContext>();
            optionsBuilder.UseNpgsql(
                "Host=localhost;Port=5433;Database=moneyjudgement;Username=moneyjudgement;Password=moneyjudgement",
                x => x.MigrationsHistoryTable("__EFMigrationsHistory", "bill_splitting"));

            return new BillSplittingDbContext(optionsBuilder.Options);
        }
    }
}
