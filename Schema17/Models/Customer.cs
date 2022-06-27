using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Schema17.Models
{
    public partial class Customer
    {
        public Customer()
        {
            SalesInvoices = new HashSet<SalesInvoice>();
            Subscriptions = new HashSet<Subscription>();
        }

        [DisplayName("Customer ID")]
        public int CustId { get; set; }
        [DisplayName("Customer Name")]
        public string Custname { get; set; } = null!;
        [DisplayName("Shipping Address")]
        public string Shippingaddress { get; set; } = null!;

        public virtual ICollection<SalesInvoice> SalesInvoices { get; set; }
        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}
