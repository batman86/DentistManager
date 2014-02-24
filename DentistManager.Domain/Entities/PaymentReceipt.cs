//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DentistManager.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class PaymentReceipt
    {
        public int ReceiptID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> PatientPaymentID { get; set; }
        public string UserID { get; set; }
        public Nullable<int> ClinicID { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Clinic Clinic { get; set; }
        public virtual PatientPayment PatientPayment { get; set; }
    }
}
