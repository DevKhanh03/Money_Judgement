using MoneyJudgement.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyJudgement.Modules.GroupManagement.Domain
{
    public enum GroupInviteStatus { Pending, Accepted, Declined, Expired }

    public class GroupInvite : BaseEntity
    {
        public Guid GroupId { get; set; }
        public Guid InvitedByUserId { get; set; }
        public string Token { get; set; } = default!;
        public string QrCodeUrl { get; set; } = default!;
        public string InviteLink { get; set; } = default!;
        public GroupInviteStatus Status { get; set; } = GroupInviteStatus.Pending;
        public DateTime ExpiresAt { get; set; }

        public Group Group { get; set; } = default!;
    }
}
