using MoneyJudgement.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyJudgement.Modules.Reporting.Domain
{
    public class DebtSnapshot : BaseEntity
    {
        public Guid GroupId { get; set; }
        public Guid FromUserId { get; set; }
        public Guid ToUserId { get; set; }
        public decimal Amount { get; set; }
        public DateTime LastUpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
