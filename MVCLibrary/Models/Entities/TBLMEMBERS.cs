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
    
    public partial class TBLMEMBERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLMEMBERS()
        {
            this.TBLMOVE = new HashSet<TBLMOVE>();
            this.TBLPUNISHMENT = new HashSet<TBLPUNISHMENT>();
            this.TBLPUNISHMENT1 = new HashSet<TBLPUNISHMENT>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
        public string SURNAME { get; set; }
        public string MAIL { get; set; }
        public string NICKNAME { get; set; }
        public string PASSWORD { get; set; }
        public string PHOTGHRAPH { get; set; }
        public string PHONENUMBER { get; set; }
        public string SCHOOL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLMOVE> TBLMOVE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLPUNISHMENT> TBLPUNISHMENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLPUNISHMENT> TBLPUNISHMENT1 { get; set; }
    }
}
