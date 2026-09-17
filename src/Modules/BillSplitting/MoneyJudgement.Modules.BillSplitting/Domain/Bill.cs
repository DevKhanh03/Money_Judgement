using MoneyJudgement.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyJudgement.Modules.BillSplitting.Domain
{
    public enum SplitType { Equal, Percentage, Exact, Shares, Itemized }
    public enum BillStatus { Active, Locked, Deleted }

    public class Bill : BaseEntity
    {
        public Guid GroupId { get; set; }
        public Guid CategoryId { get; set; }
        public string Title { get; set; } = default!;
        public string? Description { get; set; }
        public decimal TotalAmount { get; set; }
        public Guid PaidByUserId { get; set; }
        public SplitType SplitType { get; set; }
        public DateOnly BillDate { get; set; }
        public Guid CreatedByUserId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string? AttachmentUrl { get; set; }
        public BillStatus Status { get; set; } = BillStatus.Active;

        public Category Category { get; set; } = default!;
        public ICollection<BillSplitDetail> SplitDetails { get; set; } = new List<BillSplitDetail>();
    }
}
