using MoneyJudgement.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyJudgement.Modules.BillSplitting.Domain
{
    public class BillSplitDetail : BaseEntity
    {
        public Guid BillId { get; set; }
        public Guid GroupMemberId { get; set; }
        public decimal AmountOwed { get; set; }
        public decimal? SplitValue { get; set; } // %, số share, hoặc số tiền exact tùy SplitType
        public bool IsSettled { get; set; }

        public Bill Bill { get; set; } = default!;
    }
}
