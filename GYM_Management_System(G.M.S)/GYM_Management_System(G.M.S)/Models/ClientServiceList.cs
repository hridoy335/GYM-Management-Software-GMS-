//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GYM_Management_System_G.M.S_.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClientServiceList
    {
        public int ClientServiceListId { get; set; }
        public int ClientId { get; set; }
        public int ServiceId { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Servicess Servicess { get; set; }
    }
}
