using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contatos.Models;

namespace Contatos.DAO
{
    public class ContatoTelefoneDAO
    {
        public void Create(ContatoTelefone telefone)
        {
            using (var contexto = new EntidadesContatosDB())
            {
                contexto.ContatoTelefone.Add(telefone);
                contexto.SaveChanges();
            }
        }

        public IList<ContatoTelefone> Read()
        {
            using (var contexto = new EntidadesContatosDB())
            {
                return contexto.ContatoTelefone.Include("TipoTelefone").ToList();
            }
        }

        public void Update(ContatoTelefone telefone)
        {
            using (var contexto = new EntidadesContatosDB())
            {
                contexto.Entry(telefone).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Delete(ContatoTelefone telefone)
        {
            using (var contexto = new EntidadesContatosDB())
            {
                contexto.Entry(telefone).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }

        public ContatoTelefone GetByID(int Id)
        {
            using (var contexto = new EntidadesContatosDB())
            {
                return contexto.ContatoTelefone.Where(c => c.ContatoTelefoneID == Id).FirstOrDefault();
            }
        }
    }
}