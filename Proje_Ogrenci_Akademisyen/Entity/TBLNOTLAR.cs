//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proje_Ogrenci_Akademisyen.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLNOTLAR
    {
        public int NotID { get; set; }
        public Nullable<int> Sinav1 { get; set; }
        public Nullable<int> Sinav2 { get; set; }
        public Nullable<int> Sinav3 { get; set; }
        public Nullable<int> Quiz1 { get; set; }
        public Nullable<int> Quiz2 { get; set; }
        public Nullable<int> Proje { get; set; }
        public Nullable<decimal> Ortalama { get; set; }
        public Nullable<int> Ders { get; set; }
        public Nullable<int> Ogrenci { get; set; }
    
        public virtual TBLDERSLER TBLDERSLER { get; set; }
        public virtual TBLOGRENCI TBLOGRENCI { get; set; }
    }
}
