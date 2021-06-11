using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UrbanMediMart.Models
{
    public partial class Orders
    {
        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShippingAddress { get; set; }
        public string ReciptantName { get; set; }
        public string ReciptantPhone { get; set; }
        public string PaymentMethod { get; set; }
        public double? OrderTotal { get; set; }
        public string OrderStatus { get; set; }

        public virtual Customers Customer { get; set; }
    }
}
