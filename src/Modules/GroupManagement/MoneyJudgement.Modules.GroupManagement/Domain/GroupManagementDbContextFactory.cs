using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MoneyJudgement.Modules.GroupManagement.Domain
{
    public class GroupManagementDbContextFactory : IDesignTimeDbContextFactory<GroupManagementDbContext>
    {
        public GroupManagementDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<GroupManagementDbContext>();
            optionsBuilder.UseNpgsql(
                "Host=localhost;Port=5433;Database=moneyjudgement;Username=moneyjudgement;Password=moneyjudgement",
                x => x.MigrationsHistoryTable("__EFMigrationsHistory", "group_management"));

            return new GroupManagementDbContext(optionsBuilder.Options);
        }
    }
}
