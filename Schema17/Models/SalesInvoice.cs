using System;
using System.Collections.Generic;

namespace Schema17.Models
{
    public partial class SalesInvoice
    {
        public int SalesInvoiceId { get; set; }
        public int? CustId { get; set; }
        public int? ItemId { get; set; }
        public DateTime? Date { get; set; }

        public virtual Customer? Cust { get; set; }
        public virtual Item? Item { get; set; }
    }
}
