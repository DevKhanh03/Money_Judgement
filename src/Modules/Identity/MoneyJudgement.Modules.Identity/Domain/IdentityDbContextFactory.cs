using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MoneyJudgement.Modules.Identity.Domain
{
    public class IdentityDbContextFactory : IDesignTimeDbContextFactory<IdentityDbContext>
    {
        public IdentityDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<IdentityDbContext>();
            optionsBuilder.UseNpgsql(
                "Host=localhost;Port=5433;Database=moneyjudgement;Username=moneyjudgement;Password=moneyjudgement",
                x => x.MigrationsHistoryTable("__EFMigrationsHistory", "identity"));

            return new IdentityDbContext(optionsBuilder.Options);
        }
    }
}
