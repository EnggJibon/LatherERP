//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP.DatabaseAccessLayer.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class INV_CrustLeatherReceiveRef
    {
        public long CLReceiveRefID { get; set; }
        public Nullable<long> CLReceiveID { get; set; }
        public string CLReceiveNo { get; set; }
        public Nullable<long> CrustLeatherIssueID { get; set; }
        public string CrustLeatherIssueNo { get; set; }
        public Nullable<System.DateTime> CrustLeatherIssueDate { get; set; }
        public string RecordStatus { get; set; }
        public Nullable<int> ReceiveBy { get; set; }
        public Nullable<System.DateTime> ReceiveDate { get; set; }
        public string ReceiveNote { get; set; }
        public Nullable<int> CheckedBy { get; set; }
        public Nullable<System.DateTime> CheckDate { get; set; }
        public string CheckNote { get; set; }
        public Nullable<System.DateTime> SetOn { get; set; }
        public Nullable<int> SetBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public string IPAddress { get; set; }
    
        public virtual INV_CrustLeatherIssue INV_CrustLeatherIssue { get; set; }
        public virtual INV_CrustLeatherReceive INV_CrustLeatherReceive { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual User User2 { get; set; }
        public virtual User User3 { get; set; }
    }
}