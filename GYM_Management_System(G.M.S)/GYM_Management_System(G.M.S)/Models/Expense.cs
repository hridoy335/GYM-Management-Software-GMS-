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
    
    public partial class Expense
    {
        public int ExpenseId { get; set; }
        public string ExpenseProductName { get; set; }
        public string ExpenseProductQuantity { get; set; }
        public int ExpenseProductAmount { get; set; }
        public System.DateTime ExpenseBuyDate { get; set; }
        public int EmployeeId { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
