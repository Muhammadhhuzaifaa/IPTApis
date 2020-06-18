//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IptApis.Models.PointRegistration.PointDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Config
    {
        public Nullable<int> CreditLimit { get; set; }
        public int configID { get; set; }
        public int SemesterID { get; set; }
        public byte RegistrationStatus { get; set; }
        public Nullable<long> SemesterStartDate { get; set; }
        public Nullable<long> SemesterEndDate { get; set; }
        public Nullable<long> RegistrationStartDate { get; set; }
        public Nullable<long> RegistrationEndDate { get; set; }
        public Nullable<long> FeedbackStartDate { get; set; }
        public Nullable<long> FeedbackEndDate { get; set; }
    
        public virtual Semester Semester { get; set; }
    }
}