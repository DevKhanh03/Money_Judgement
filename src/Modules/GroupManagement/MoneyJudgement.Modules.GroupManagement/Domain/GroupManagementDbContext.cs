using Microsoft.EntityFrameworkCore;

namespace MoneyJudgement.Modules.GroupManagement.Domain
{
    public class GroupManagementDbContext : DbContext
    {
        public GroupManagementDbContext(DbContextOptions<GroupManagementDbContext> options) : base(options) { }

        public DbSet<Group> Groups => Set<Group>();
        public DbSet<GroupMember> GroupMembers => Set<GroupMember>();
        public DbSet<GroupInvite> GroupInvites => Set<GroupInvite>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("group_management");

            // Group -> GroupMembers (1 Group có nhiều Members)
            builder.Entity<GroupMember>()
                .HasOne(m => m.Group)
                .WithMany(g => g.Members)
                .HasForeignKey(m => m.GroupId)
                .OnDelete(DeleteBehavior.Cascade);

            // Group -> GroupInvites (1 Group có nhiều Invites)
            builder.Entity<GroupInvite>()
                .HasOne(i => i.Group)
                .WithMany()
                .HasForeignKey(i => i.GroupId)
                .OnDelete(DeleteBehavior.Cascade);

            // Unique constraint: mỗi user chỉ có 1 membership trong 1 group
            builder.Entity<GroupMember>()
                .HasIndex(m => new { m.GroupId, m.UserId })
                .IsUnique();

            // Unique constraint cho invite token
            builder.Entity<GroupInvite>()
                .HasIndex(i => i.Token)
                .IsUnique();

            // Lưu enum dưới dạng string
            builder.Entity<GroupMember>()
                .Property(m => m.Role)
                .HasConversion<string>();

            builder.Entity<GroupMember>()
                .Property(m => m.Status)
                .HasConversion<string>();

            builder.Entity<GroupInvite>()
                .Property(i => i.Status)
                .HasConversion<string>();

            base.OnModelCreating(builder);
        }
    }
}
