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
    
    public partial class PatientHistory
    {
        public int HistoryID { get; set; }
        public Nullable<int> PatientID { get; set; }
        public string Name { get; set; }
        public string Descripation { get; set; }
    
        public virtual Patient Patient { get; set; }
    }
}
