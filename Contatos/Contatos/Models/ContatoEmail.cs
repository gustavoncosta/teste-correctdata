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
    
    public partial class ContatoEmail
    {
        public int ContatoEmailID { get; set; }
        public int ContatoID { get; set; }
        public int TipoEmailID { get; set; }
        public string ContatoEmail1 { get; set; }
    
        public virtual Contato Contato { get; set; }
        public virtual TipoEmail TipoEmail { get; set; }
    }
}
