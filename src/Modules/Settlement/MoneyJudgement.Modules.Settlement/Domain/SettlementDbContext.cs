using Microsoft.EntityFrameworkCore;

namespace MoneyJudgement.Modules.Settlement.Domain
{
    public class SettlementDbContext : DbContext
    {
        public SettlementDbContext(DbContextOptions<SettlementDbContext> options) : base(options) { }

        public DbSet<Settlement> Settlements => Set<Settlement>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("settlement");

            // Precision cho cột tiền
            builder.Entity<Settlement>()
                .Property(s => s.Amount)
                .HasPrecision(18, 2);

            // Lưu enum dưới dạng string
            builder.Entity<Settlement>()
                .Property(s => s.Method)
                .HasConversion<string>();

            builder.Entity<Settlement>()
                .Property(s => s.Status)
                .HasConversion<string>();

            // Index cho truy vấn theo group
            builder.Entity<Settlement>()
                .HasIndex(s => s.GroupId);

            // Index cho truy vấn theo cặp user
            builder.Entity<Settlement>()
                .HasIndex(s => new { s.FromUserId, s.ToUserId });

            base.OnModelCreating(builder);
        }
    }
}
