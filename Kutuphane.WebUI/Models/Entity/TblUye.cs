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

    public partial class TblUye
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblUye()
        {
            this.TblCeza = new HashSet<TblCeza>();
            this.TblHareket = new HashSet<TblHareket>();
        }
    
        public int Id { get; set; }
        [Required(ErrorMessage ="Ad alan� bo� b�rak�lamaz.")]
        [StringLength(20,ErrorMessage ="En fazla 20 karakter girebilirsiniz")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Soyad alan� bo� b�rak�lamaz.")]
        [StringLength(20, ErrorMessage = "En fazla 20 karakter girebilirsiniz")]
        public string Soyad { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string EMail { get; set; }

        [Required(ErrorMessage = "Kullan�c� alan� bo� b�rak�lamaz.")]
        [StringLength(20, ErrorMessage = "En fazla 20 karakter girebilirsiniz")]
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Fotograf { get; set; }
        public string Telefon { get; set; }
        public string Okul { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblCeza> TblCeza { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblHareket> TblHareket { get; set; }
    }
}
