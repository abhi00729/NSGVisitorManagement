//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Visitor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Visitor()
        {
            this.CoVisitors = new HashSet<CoVisitor>();
        }
    
        public long VisitorID { get; set; }
        public string MachineID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string MobileNo { get; set; }
        public int IdentityTypeID { get; set; }
        public string IdentityNumber { get; set; }
        public string VisitorAddress { get; set; }
        public Nullable<long> CityID { get; set; }
        public Nullable<int> StateID { get; set; }
        public string VehicleNumber { get; set; }
        public string Purpose { get; set; }
        public string PersonEmpCode { get; set; }
        public string PersonName { get; set; }
        public Nullable<int> RankID { get; set; }
        public Nullable<int> UnitID { get; set; }
        public Nullable<int> QuarterTypeID { get; set; }
        public Nullable<int> QuarterNumber { get; set; }
        public System.DateTime InTime { get; set; }
        public Nullable<System.DateTime> OutTime { get; set; }
        public byte[] VisitorPhoto { get; set; }
        public int EntryUserID { get; set; }
        public System.DateTime EntryDate { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        public virtual CoreCity CoreCity { get; set; }
        public virtual CoreIdentityType CoreIdentityType { get; set; }
        public virtual CoreQuarterType CoreQuarterType { get; set; }
        public virtual CoreRank CoreRank { get; set; }
        public virtual CoreState CoreState { get; set; }
        public virtual CoreUnit CoreUnit { get; set; }
        public virtual CoreUser CoreUser { get; set; }
        public virtual CoreUser CoreUser1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoVisitor> CoVisitors { get; set; }
    }
}