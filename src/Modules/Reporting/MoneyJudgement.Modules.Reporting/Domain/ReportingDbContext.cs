using Microsoft.EntityFrameworkCore;

namespace MoneyJudgement.Modules.Reporting.Domain
{
    public class ReportingDbContext : DbContext
    {
        public ReportingDbContext(DbContextOptions<ReportingDbContext> options) : base(options) { }

        public DbSet<DebtSnapshot> DebtSnapshots => Set<DebtSnapshot>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("reporting");

            // Precision cho cột tiền
            builder.Entity<DebtSnapshot>()
                .Property(d => d.Amount)
                .HasPrecision(18, 2);

            // Unique constraint: mỗi cặp (Group, FromUser, ToUser) chỉ có 1 snapshot
            builder.Entity<DebtSnapshot>()
                .HasIndex(d => new { d.GroupId, d.FromUserId, d.ToUserId })
                .IsUnique();

            base.OnModelCreating(builder);
        }
    }
}
