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
    
    public partial class INV_CrustLeatherIssue
    {
        public INV_CrustLeatherIssue()
        {
            this.INV_CrustLeatherIssueColor = new HashSet<INV_CrustLeatherIssueColor>();
            this.INV_CrustLeatherReceiveColor = new HashSet<INV_CrustLeatherReceiveColor>();
            this.INV_CrustLeatherReceiveItem = new HashSet<INV_CrustLeatherReceiveItem>();
            this.INV_CrustLeatherReceiveRef = new HashSet<INV_CrustLeatherReceiveRef>();
            this.INV_CrustLeatherIssueItem = new HashSet<INV_CrustLeatherIssueItem>();
        }
    
        public long CrustLeatherIssueID { get; set; }
        public string CrustLeatherIssueNo { get; set; }
        public Nullable<System.DateTime> CrustLeatherIssueDate { get; set; }
        public string IssueCategory { get; set; }
        public string IssueFor { get; set; }
        public Nullable<byte> IssueFrom { get; set; }
        public Nullable<byte> IssueTo { get; set; }
        public string RecordStatus { get; set; }
        public Nullable<int> IssuedBy { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public string IssueNote { get; set; }
        public Nullable<int> CheckedBy { get; set; }
        public Nullable<System.DateTime> CheckDate { get; set; }
        public string CheckNote { get; set; }
        public Nullable<System.DateTime> SetOn { get; set; }
        public Nullable<int> SetBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public string IPAddress { get; set; }
        public Nullable<long> CrustLeatherQCID { get; set; }
        public string IssueQCStatus { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual SYS_Store SYS_Store { get; set; }
        public virtual SYS_Store SYS_Store1 { get; set; }
        public virtual User User2 { get; set; }
        public virtual User User3 { get; set; }
        public virtual ICollection<INV_CrustLeatherIssueColor> INV_CrustLeatherIssueColor { get; set; }
        public virtual PRD_CrustLeatherQC PRD_CrustLeatherQC { get; set; }
        public virtual ICollection<INV_CrustLeatherReceiveColor> INV_CrustLeatherReceiveColor { get; set; }
        public virtual ICollection<INV_CrustLeatherReceiveItem> INV_CrustLeatherReceiveItem { get; set; }
        public virtual ICollection<INV_CrustLeatherReceiveRef> INV_CrustLeatherReceiveRef { get; set; }
        public virtual ICollection<INV_CrustLeatherIssueItem> INV_CrustLeatherIssueItem { get; set; }
    }
}
