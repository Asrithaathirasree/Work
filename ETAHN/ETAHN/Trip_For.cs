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
    
    public partial class Trip_For
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trip_For()
        {
            this.Trip_Check_List = new HashSet<Trip_Check_List>();
        }
    
        public int Id { get; set; }
        public string Study { get; set; }
        public string Employment { get; set; }
        public string Tour { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trip_Check_List> Trip_Check_List { get; set; }
    }
}
