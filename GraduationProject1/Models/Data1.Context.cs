﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GraduationProject1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AirportDBEntities : DbContext
    {
        public AirportDBEntities()
            : base("name=AirportDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AirlineCompany> AirlineCompanies { get; set; }
        public virtual DbSet<AirportInformation> AirportInformations { get; set; }
        public virtual DbSet<AirportTerminal> AirportTerminals { get; set; }
        public virtual DbSet<ApronInformation> ApronInformations { get; set; }
        public virtual DbSet<CarparkAndSecuritiesInfo> CarparkAndSecuritiesInfoes { get; set; }
        public virtual DbSet<Carpark> Carparks { get; set; }
        public virtual DbSet<EmployeeInfo> EmployeeInfos { get; set; }
        public virtual DbSet<OfficeInformation> OfficeInformations { get; set; }
        public virtual DbSet<Office> Offices { get; set; }
        public virtual DbSet<SecurityInfo> SecurityInfos { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TechnicUnit> TechnicUnits { get; set; }
        public virtual DbSet<TechnicUnitInfo> TechnicUnitInfos { get; set; }
        public virtual DbSet<WorkField> WorkFields { get; set; }
    }
}
