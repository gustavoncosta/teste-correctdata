﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EntidadesContatosDB : DbContext
    {
        public EntidadesContatosDB()
            : base("name=EntidadesContatosDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Contato> Contato { get; set; }
        public virtual DbSet<ContatoEmail> ContatoEmail { get; set; }
        public virtual DbSet<ContatoTelefone> ContatoTelefone { get; set; }
        public virtual DbSet<TipoEmail> TipoEmail { get; set; }
        public virtual DbSet<TipoTelefone> TipoTelefone { get; set; }
    }
}