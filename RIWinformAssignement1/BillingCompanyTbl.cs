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
    
    public partial class BillingCompanyTbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BillingCompanyTbl()
        {
            this.BillingCompanyUserTbls = new HashSet<BillingCompanyUserTbl>();
        }
    
        public long BillingCompanyID { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string EmailID { get; set; }
        public string ContactNo { get; set; }
        public Nullable<long> CityID { get; set; }
        public string WebsiteUrl { get; set; }
        public string PinCode { get; set; }
    
        public virtual CityTbl CityTbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillingCompanyUserTbl> BillingCompanyUserTbls { get; set; }
    }
}
