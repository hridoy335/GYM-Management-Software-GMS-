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
    
    public partial class Attendence
    {
        public int AttendenceId { get; set; }
        public Nullable<int> ClientId { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public System.DateTime FromTime { get; set; }
        public System.DateTime ToTime { get; set; }
        public string AttendenceStatus { get; set; }
        public System.DateTime AttendenceDate { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
