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
    
    public partial class Vehicle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehicle()
        {
            this.Home_Needs = new HashSet<Home_Needs>();
        }
    
        public int Id { get; set; }
        public string Insurane_date_Renewal { get; set; }
        public string RCBook_Details { get; set; }
        public string Service_DueDate { get; set; }
        public int OwnershipOfId { get; set; }
        public int Having_LicenceId { get; set; }
        public int OwnershipOfId1 { get; set; }
        public int Having_LicenceId1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Home_Needs> Home_Needs { get; set; }
        public virtual OwnershipOf OwnershipOf { get; set; }
        public virtual Having_Licence Having_Licence { get; set; }
    }
}
