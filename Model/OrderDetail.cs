using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UrbanMediMart.Model
{
    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public int Quantity { get; set; }
        public double SubTotal { get; set; }

        public virtual Orders Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
