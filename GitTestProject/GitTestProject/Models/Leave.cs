//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GitTestProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Leave
    {
        public int LeaveId { get; set; }
        public Nullable<int> emp_id { get; set; }
        public Nullable<System.DateTime> From_date { get; set; }
        public Nullable<System.DateTime> End_date { get; set; }
        public string Leave_type { get; set; }
        public string Reason { get; set; }
    
        public virtual employee employee { get; set; }
    }
}
