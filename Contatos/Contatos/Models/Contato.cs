//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Contatos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contato
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contato()
        {
            this.ContatoEmail = new HashSet<ContatoEmail>();
            this.ContatoTelefone = new HashSet<ContatoTelefone>();
        }
    
        public int ContatoID { get; set; }
        public string ContatoNome { get; set; }
        public System.DateTime ContatoDataNascimento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContatoEmail> ContatoEmail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContatoTelefone> ContatoTelefone { get; set; }
    }
}
