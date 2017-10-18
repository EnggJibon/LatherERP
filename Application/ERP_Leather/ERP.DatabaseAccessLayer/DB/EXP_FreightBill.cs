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
    
    public partial class EXP_FreightBill
    {
        public long FreightBillID { get; set; }
        public string FreightBillNo { get; set; }
        public string FreightBillRef { get; set; }
        public Nullable<System.DateTime> FreightBillDate { get; set; }
        public Nullable<long> LCID { get; set; }
        public Nullable<long> PIID { get; set; }
        public Nullable<long> CIID { get; set; }
        public Nullable<int> FreightAgentID { get; set; }
        public string NotifyTo { get; set; }
        public string MSNo { get; set; }
        public Nullable<System.DateTime> MSDate { get; set; }
        public string ShipmentOf { get; set; }
        public string ShipmentTo { get; set; }
        public string WBNo { get; set; }
        public Nullable<System.DateTime> WBDate { get; set; }
        public Nullable<decimal> FreightWeight { get; set; }
        public Nullable<decimal> FreightRate { get; set; }
        public Nullable<decimal> FreightValue { get; set; }
        public Nullable<byte> FreightBillCurrency { get; set; }
        public Nullable<byte> ExchangeCurrency { get; set; }
        public Nullable<decimal> ExchangeRate { get; set; }
        public Nullable<decimal> ExchangeValue { get; set; }
        public Nullable<decimal> THCharge { get; set; }
        public Nullable<decimal> AirWayBill { get; set; }
        public Nullable<decimal> FCSMYCCharge { get; set; }
        public Nullable<decimal> SSCMCCCharge { get; set; }
        public Nullable<decimal> OtherCharge { get; set; }
        public Nullable<decimal> LocalCarringCharge { get; set; }
        public Nullable<decimal> CustomCharge { get; set; }
        public Nullable<decimal> VATAsReceipt { get; set; }
        public Nullable<decimal> LoadUnloadCharge { get; set; }
        public Nullable<decimal> GSPEXpence { get; set; }
        public Nullable<decimal> AgencyCommision { get; set; }
        public Nullable<decimal> SpecialDeliveryCharge { get; set; }
        public Nullable<decimal> TotalAmt { get; set; }
        public Nullable<decimal> AdvanceAmt { get; set; }
        public Nullable<decimal> NetFreightAmt { get; set; }
        public Nullable<decimal> TrminalCharge { get; set; }
        public Nullable<decimal> ExamineCharge { get; set; }
        public Nullable<decimal> AmendmentCharge { get; set; }
        public string FreightBillNote { get; set; }
        public string RecordStatus { get; set; }
        public Nullable<int> CheckedBy { get; set; }
        public Nullable<System.DateTime> CheckDate { get; set; }
        public Nullable<System.DateTime> SetOn { get; set; }
        public Nullable<int> SetBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public string IPAddress { get; set; }
        public string ShipmentFrom { get; set; }
        public Nullable<long> BLID { get; set; }
    
        public virtual EXP_CI EXP_CI { get; set; }
        public virtual Sys_Currency Sys_Currency { get; set; }
        public virtual Sys_Buyer Sys_Buyer { get; set; }
        public virtual Sys_Currency Sys_Currency1 { get; set; }
        public virtual EXP_LCOpening EXP_LCOpening { get; set; }
        public virtual User User { get; set; }
        public virtual EXP_LeatherPI EXP_LeatherPI { get; set; }
        public virtual User User1 { get; set; }
        public virtual EXP_BillofLading EXP_BillofLading { get; set; }
    }
}