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
    
    public partial class ClientBillTransection
    {
        public int TransectionId { get; set; }
        public int ClientBillId { get; set; }
        public System.DateTime TransectionDate { get; set; }
    
        public virtual ClientBill ClientBill { get; set; }
    }
}
