//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCLibrary.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class TBLMEMBERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLMEMBERS()
        {
            this.TBLPUNISHMENT = new HashSet<TBLPUNISHMENT>();
            this.TBLPUNISHMENT1 = new HashSet<TBLPUNISHMENT>();
        }
    
        public int ID { get; set; }
        [Required(ErrorMessage ="Ad� alan� bo� ge�ilemez!"),StringLength(50,ErrorMessage ="En fazla 50 karakter!")]
        public string NAME { get; set; }
        [Required(ErrorMessage = "Soyad� alan� bo� ge�ilemez")]
        public string SURNAME { get; set; }
        [Required(ErrorMessage = "Mail alan� bo� ge�ilemez")]
        public string MAIL { get; set; }
        [Required(ErrorMessage = "Nickname alan� bo� ge�ilemez")]
        public string NICKNAME { get; set; }
        [Required(ErrorMessage = "�ifre alan� bo� ge�ilemez"),StringLength(20,ErrorMessage ="En fazla 20 karakter girilebilir!")]
        public string PASSWORD { get; set; }
        [Required(ErrorMessage = "Foto�raf alan� bo� ge�ilemez")]
        public string PHOTGHRAPH { get; set; }
        [Required(ErrorMessage = "Telefon alan� bo� ge�ilemez")]
        public string PHONENUMBER { get; set; }
        [Required(ErrorMessage = "Okul alan� bo� ge�ilemez")]
        public string SCHOOL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLPUNISHMENT> TBLPUNISHMENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLPUNISHMENT> TBLPUNISHMENT1 { get; set; }
    }
}
