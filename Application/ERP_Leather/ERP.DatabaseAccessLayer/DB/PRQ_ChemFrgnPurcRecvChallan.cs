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
    
    public partial class PRQ_ChemFrgnPurcRecvChallan
    {
        public int ReceiveChallanID { get; set; }
        public Nullable<int> PLReceiveID { get; set; }
        public Nullable<int> ReceiveID { get; set; }
        public string ReceiveChallanNo { get; set; }
        public Nullable<System.DateTime> ChallanDate { get; set; }
        public Nullable<decimal> CarringCost { get; set; }
        public Nullable<decimal> LaborCost { get; set; }
        public Nullable<decimal> OtherCost { get; set; }
        public Nullable<byte> Currency { get; set; }
        public Nullable<byte> ExchangeCurrency { get; set; }
        public Nullable<decimal> ExchangeRate { get; set; }
        public Nullable<decimal> ExchangeValue { get; set; }
        public Nullable<byte> CostIndicator { get; set; }
        public string Remark { get; set; }
        public string RecordStatus { get; set; }
        public Nullable<System.DateTime> SetOn { get; set; }
        public Nullable<int> SetBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public string IPAddress { get; set; }
    
        public virtual PRQ_ChemFrgnPurcRecv PRQ_ChemFrgnPurcRecv { get; set; }
        public virtual Sys_Currency Sys_Currency { get; set; }
        public virtual Sys_Currency Sys_Currency1 { get; set; }
        public virtual User User { get; set; }
        public virtual PRQ_ChemFrgnPurcRecvPL PRQ_ChemFrgnPurcRecvPL { get; set; }
        public virtual User User1 { get; set; }
    }
}
