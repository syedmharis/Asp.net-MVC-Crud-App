using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Schema17.Models
{
    public partial class Newsletter
    {
        public Newsletter()
        {
            Subscriptions = new HashSet<Subscription>();
        }
        [DisplayName("Letter ID")]
        public int LetterId { get; set; }
        [DisplayName("News Letter Name")]
        public string NewsLetterName { get; set; } = null!;

        public string Version { get; set; } = null!;

        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}
