using Microsoft.EntityFrameworkCore;

namespace MoneyJudgement.Modules.BillSplitting.Domain
{
    public class BillSplittingDbContext : DbContext
    {
        public BillSplittingDbContext(DbContextOptions<BillSplittingDbContext> options) : base(options) { }

        public DbSet<Bill> Bills => Set<Bill>();
        public DbSet<BillSplitDetail> BillSplitDetails => Set<BillSplitDetail>();
        public DbSet<Category> Categories => Set<Category>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("bill_splitting");

            // Bill -> Category (nhiều Bill thuộc 1 Category)
            builder.Entity<Bill>()
                .HasOne(b => b.Category)
                .WithMany()
                .HasForeignKey(b => b.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            // Bill -> BillSplitDetails (1 Bill có nhiều SplitDetails)
            builder.Entity<BillSplitDetail>()
                .HasOne(d => d.Bill)
                .WithMany(b => b.SplitDetails)
                .HasForeignKey(d => d.BillId)
                .OnDelete(DeleteBehavior.Cascade);

            // Precision cho cột tiền
            builder.Entity<Bill>()
                .Property(b => b.TotalAmount)
                .HasPrecision(18, 2);

            builder.Entity<BillSplitDetail>()
                .Property(d => d.AmountOwed)
                .HasPrecision(18, 2);

            builder.Entity<BillSplitDetail>()
                .Property(d => d.SplitValue)
                .HasPrecision(18, 4);

            // Lưu enum dưới dạng string
            builder.Entity<Bill>()
                .Property(b => b.SplitType)
                .HasConversion<string>();

            builder.Entity<Bill>()
                .Property(b => b.Status)
                .HasConversion<string>();

            base.OnModelCreating(builder);
        }
    }
}
