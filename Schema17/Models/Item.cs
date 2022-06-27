using System;
using System.Collections.Generic;

namespace Schema17.Models
{
    public partial class Item
    {
        public Item()
        {
            SalesInvoices = new HashSet<SalesInvoice>();
        }

        public int ItemId { get; set; }
        public string ItemName { get; set; } = null!;
        public int Supplier { get; set; }
        public double Price { get; set; }

        public virtual Supplier SupplierNavigation { get; set; } = null!;
        public virtual ICollection<SalesInvoice> SalesInvoices { get; set; }
    }
}
