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
    
    public partial class VehileKm_Tracker
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VehileKm_Tracker()
        {
            this.Home_Needs = new HashSet<Home_Needs>();
        }
    
        public int Id { get; set; }
        public string Distance_Covered { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Date { get; set; }
        public string Fuel_FillUp_Amount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Home_Needs> Home_Needs { get; set; }
    }
}
