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
    
    public partial class Sys_Country
    {
        public Sys_Country()
        {
            this.PRQ_ChemicalPI = new HashSet<PRQ_ChemicalPI>();
            this.Sys_Supplier = new HashSet<Sys_Supplier>();
            this.EXP_LeatherPI = new HashSet<EXP_LeatherPI>();
            this.EXP_ExportForm = new HashSet<EXP_ExportForm>();
            this.LCM_LCOpening = new HashSet<LCM_LCOpening>();
        }
    
        public int CountryID { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> SetOn { get; set; }
        public Nullable<int> SetBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public string IPAddress { get; set; }
    
        public virtual ICollection<PRQ_ChemicalPI> PRQ_ChemicalPI { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual ICollection<Sys_Supplier> Sys_Supplier { get; set; }
        public virtual ICollection<EXP_LeatherPI> EXP_LeatherPI { get; set; }
        public virtual ICollection<EXP_ExportForm> EXP_ExportForm { get; set; }
        public virtual ICollection<LCM_LCOpening> LCM_LCOpening { get; set; }
    }
}