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
    
    public partial class UspGetPurchaseWithBillInformation_Result
    {
        public int SupplierID { get; set; }
        public string SupplierCode { get; set; }
        public byte StoreID { get; set; }
        public byte ItemTypeID { get; set; }
        public string SupplierName { get; set; }
        public string StoreName { get; set; }
        public string ItemTypeName { get; set; }
        public decimal TotalQuantity { get; set; }
        public decimal TotalValue { get; set; }
        public decimal AvgPrice { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal AveragePrice { get; set; }
    }
}