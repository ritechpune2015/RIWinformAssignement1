//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RIWinformAssignement1
{
    using System;
    using System.Collections.Generic;
    
    public partial class CityTbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CityTbl()
        {
            this.BillingCompanyTbls = new HashSet<BillingCompanyTbl>();
        }
    
        public long CityID { get; set; }
        public string CityName { get; set; }
        public Nullable<long> StateID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillingCompanyTbl> BillingCompanyTbls { get; set; }
        public virtual StateTbl StateTbl { get; set; }
    }
}