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
    
    public partial class Clinic
    {
        public Clinic()
        {
            this.Appointments = new HashSet<Appointment>();
            this.PatientPayments = new HashSet<PatientPayment>();
            this.PaymentReceipts = new HashSet<PaymentReceipt>();
            this.Storages = new HashSet<Storage>();
        }
    
        public int ClinicID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
    
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<PatientPayment> PatientPayments { get; set; }
        public virtual ICollection<PaymentReceipt> PaymentReceipts { get; set; }
        public virtual ICollection<Storage> Storages { get; set; }
    }
}
