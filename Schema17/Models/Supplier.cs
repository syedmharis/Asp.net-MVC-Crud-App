using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Schema17.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            Items = new HashSet<Item>();
        }
        [DisplayName("Supplier ID")]
        public int SupplierId { get; set; }
        
        [DisplayName("Supplier Name")]
        public string SupplierName { get; set; } = null!;
        //[Range(0, 11, ErrorMessage = "Enter Correct Phone Number")]
        public string Phone { get; set; } = null!;

        public virtual ICollection<Item> Items { get; set; }
    }
}
