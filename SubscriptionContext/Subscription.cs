using System;
using ProjetoOOP.SharedContext;

namespace ProjetoOOP.SubscriptionContext
{
    public class Subscription : BaseContent
    {
        public Plan Plan { get; set; }

        public DateTime? EndDate { get; set; }
        public bool IsInactive => EndDate <= DateTime.Now;
    }
}