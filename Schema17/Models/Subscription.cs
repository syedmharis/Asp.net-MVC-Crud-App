using System;
using System.Collections.Generic;

namespace Schema17.Models
{
    public partial class Subscription
    {
        public int SubscriptionId { get; set; }
        public int CustId { get; set; }
        public int Newsletter { get; set; }

        public virtual Customer Cust { get; set; } = null!;
        public virtual Newsletter NewsletterNavigation { get; set; } = null!;
    }
}
