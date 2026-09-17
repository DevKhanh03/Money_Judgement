using MoneyJudgement.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyJudgement.Modules.Settlement.Domain
{
    public enum SettlementMethod { BankTransfer, Cash }
    public enum SettlementStatus { Pending, Confirmed, Rejected }

    public class Settlement : BaseEntity
    {
        public Guid GroupId { get; set; }
        public Guid FromUserId { get; set; } // người trả nợ, tạo record này
        public Guid ToUserId { get; set; }   // người nhận, người duyệt Confirm/Reject
        public decimal Amount { get; set; }
        public SettlementMethod Method { get; set; }
        public string? Note { get; set; }
        public string? ProofImageUrl { get; set; }
        public SettlementStatus Status { get; set; } = SettlementStatus.Pending;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? ConfirmedAt { get; set; }
        public DateTime? RejectedAt { get; set; }
    }
}
