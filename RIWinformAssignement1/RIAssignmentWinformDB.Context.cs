﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RIAssignmentDBEntities : DbContext
    {
        public RIAssignmentDBEntities()
            : base("name=RIAssignmentDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BillingCompanyTbl> BillingCompanyTbls { get; set; }
        public virtual DbSet<BillingCompanyUserTbl> BillingCompanyUserTbls { get; set; }
        public virtual DbSet<CityTbl> CityTbls { get; set; }
        public virtual DbSet<CountryTbl> CountryTbls { get; set; }
        public virtual DbSet<StateTbl> StateTbls { get; set; }
    }
}
