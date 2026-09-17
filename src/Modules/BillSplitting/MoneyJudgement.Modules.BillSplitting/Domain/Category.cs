using MoneyJudgement.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyJudgement.Modules.BillSplitting.Domain
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string? Icon { get; set; }
        public Guid? GroupId { get; set; } // null = category mặc định hệ thống
    }
}
