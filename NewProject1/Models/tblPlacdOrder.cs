//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewProject1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPlacdOrder
    {
        public int Id { get; set; }
        public Nullable<int> ApprovedId { get; set; }
        public Nullable<System.DateTime> OrderTime { get; set; }
        public string DeliveryAddress { get; set; }
        public Nullable<decimal> Price { get; set; }
    
        public virtual tblApprovedOrder tblApprovedOrder { get; set; }
    }
}
