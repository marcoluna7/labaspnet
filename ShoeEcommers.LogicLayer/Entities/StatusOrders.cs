//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoeEcommers.LogicLayer.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class StatusOrders
    {
        public StatusOrders()
        {
            this.Orders = new HashSet<Orders>();
        }
    
        public int Id { get; set; }
        public string Status { get; set; }
    
        public virtual ICollection<Orders> Orders { get; set; }
    }
}