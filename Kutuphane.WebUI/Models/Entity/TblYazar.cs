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
    using System.ComponentModel.DataAnnotations;

    public partial class TblYazar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblYazar()
        {
            this.TblKitap = new HashSet<TblKitap>();
        }
    
        public int Id { get; set; }
        [Required(ErrorMessage ="Yazar�n ad�n� bo� ge�emezsiniz")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Yazar�n soyad�n� bo� ge�emezsiniz")]
        public string Soyad { get; set; }
        public string Detay { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblKitap> TblKitap { get; set; }
    }
}
