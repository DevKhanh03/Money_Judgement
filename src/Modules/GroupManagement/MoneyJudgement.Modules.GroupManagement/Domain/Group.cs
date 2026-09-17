using MoneyJudgement.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyJudgement.Modules.GroupManagement.Domain
{
    public class Group : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public string? AvatarUrl { get; set; }
        public Guid OwnerId { get; set; } // tham chiếu tới UserId bên module Identity, không FK cứng
        public string CurrencyCode { get; set; } = "VND";
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<GroupMember> Members { get; set; } = new List<GroupMember>();
    }
}
