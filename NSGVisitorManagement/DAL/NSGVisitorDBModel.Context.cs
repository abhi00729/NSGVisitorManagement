﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NSGVisitorManagement.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class NSGVisitorEntities : DbContext
    {
        public NSGVisitorEntities()
            : base("name=NSGVisitorEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CoreCity> CoreCities { get; set; }
        public virtual DbSet<CoreQuarterType> CoreQuarterTypes { get; set; }
        public virtual DbSet<CoreRank> CoreRanks { get; set; }
        public virtual DbSet<CoreRelationship> CoreRelationships { get; set; }
        public virtual DbSet<CoreState> CoreStates { get; set; }
        public virtual DbSet<CoreUnit> CoreUnits { get; set; }
        public virtual DbSet<CoreUser> CoreUsers { get; set; }
        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }
        public virtual DbSet<CoreIdentityType> CoreIdentityTypes { get; set; }
        public virtual DbSet<NSGEmployee> NSGEmployees { get; set; }
        public virtual DbSet<Visitor> Visitors { get; set; }
        public virtual DbSet<CoVisitor> CoVisitors { get; set; }
    
        public virtual ObjectResult<VisitorsDetailsGet_Result> VisitorsDetailsGet(Nullable<System.DateTime> fromDate, Nullable<System.DateTime> toDate, Nullable<long> visitorID, string visitorName, string visiedPerson, Nullable<bool> checkExitTime)
        {
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("FromDate", fromDate) :
                new ObjectParameter("FromDate", typeof(System.DateTime));
    
            var toDateParameter = toDate.HasValue ?
                new ObjectParameter("ToDate", toDate) :
                new ObjectParameter("ToDate", typeof(System.DateTime));
    
            var visitorIDParameter = visitorID.HasValue ?
                new ObjectParameter("VisitorID", visitorID) :
                new ObjectParameter("VisitorID", typeof(long));
    
            var visitorNameParameter = visitorName != null ?
                new ObjectParameter("VisitorName", visitorName) :
                new ObjectParameter("VisitorName", typeof(string));
    
            var visiedPersonParameter = visiedPerson != null ?
                new ObjectParameter("VisiedPerson", visiedPerson) :
                new ObjectParameter("VisiedPerson", typeof(string));
    
            var checkExitTimeParameter = checkExitTime.HasValue ?
                new ObjectParameter("CheckExitTime", checkExitTime) :
                new ObjectParameter("CheckExitTime", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VisitorsDetailsGet_Result>("VisitorsDetailsGet", fromDateParameter, toDateParameter, visitorIDParameter, visitorNameParameter, visiedPersonParameter, checkExitTimeParameter);
        }
    }
}