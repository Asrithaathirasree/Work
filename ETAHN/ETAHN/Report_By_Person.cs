//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ETAHN
{
    using System;
    using System.Collections.Generic;
    
    public partial class Report_By_Person
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Report_By_Person()
        {
            this.ExpenseTrackers = new HashSet<ExpenseTracker>();
        }
    
        public int Id { get; set; }
        public string Person { get; set; }
        public long TotalIncome { get; set; }
        public string Till_Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExpenseTracker> ExpenseTrackers { get; set; }
    }
}