//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace project.Sqldata
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int TransactionId { get; set; }
        public Nullable<int> OrderId { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public string Mode { get; set; }
    
        public virtual Order Order { get; set; }
    }
}
