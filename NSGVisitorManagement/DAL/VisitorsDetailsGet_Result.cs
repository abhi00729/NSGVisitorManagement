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
    
    public partial class VisitorsDetailsGet_Result
    {
        public long VisitorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public System.DateTime InTime { get; set; }
        public Nullable<System.DateTime> OutTime { get; set; }
        public Nullable<System.DateTime> ValidTill { get; set; }
        public string IdentityType { get; set; }
        public string IdentityNumber { get; set; }
        public string CityName { get; set; }
        public string StateName { get; set; }
        public string VehicleNumber { get; set; }
        public string Purpose { get; set; }
        public string PersonName { get; set; }
        public string VisitedPersonMobile { get; set; }
        public string RankName { get; set; }
        public string UnitName { get; set; }
        public int CoVisitors { get; set; }
        public string EntryBy { get; set; }
        public string ExitBy { get; set; }
        public string MachineID { get; set; }
        public string BlackListed { get; set; }
    }
}
