//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace İlaçEczaOtomasyonu
{
    using System;
    using System.Collections.Generic;
    
    public partial class Satis
    {
        public int idSATIS { get; set; }
        public int CalisanID { get; set; }
        public int MusteriID { get; set; }
        public int IlacID { get; set; }
        public int Adet { get; set; }
        public int Kazanc { get; set; }
        public string Tarih { get; set; }
    
        public virtual Calisan Calisan { get; set; }
        public virtual Ilac Ilac { get; set; }
        public virtual Musteri Musteri { get; set; }
    }
}
