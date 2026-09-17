using MoneyJudgement.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyJudgement.Modules.GroupManagement.Domain
{
    public enum GroupMemberRole { Owner, Member }
    public enum GroupMemberStatus { Active, Left, Removed }

    public class GroupMember : BaseEntity
    {
        public Guid GroupId { get; set; }
        public Guid UserId { get; set; }
        public GroupMemberRole Role { get; set; } = GroupMemberRole.Member;
        public GroupMemberStatus Status { get; set; } = GroupMemberStatus.Active;
        public string? Nickname { get; set; }
        public DateTime JoinedAt { get; set; } = DateTime.UtcNow;

        public Group Group { get; set; } = default!;

        // Ràng buộc nghiệp vụ: chỉ set Status = Left khi net balance = 0
        // (kiểm tra qua Contracts của BillSplitting/Settlement ở Application layer, không đặt logic ở đây)
    }
}
