//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kutuphane.WebUI.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblKitap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblKitap()
        {
            this.TblHareket = new HashSet<TblHareket>();
        }
    
        public int Id { get; set; }
        public string Ad { get; set; }
        public Nullable<int> KategoriId { get; set; }
        public string BasimYili { get; set; }
        public string YayinEvi { get; set; }
        public string Sayfa { get; set; }
        public Nullable<int> YazarId { get; set; }
        public Nullable<bool> Durum { get; set; }
    
        public virtual TblCategory TblCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblHareket> TblHareket { get; set; }
        public virtual TblYazar TblYazar { get; set; }
    }
}
