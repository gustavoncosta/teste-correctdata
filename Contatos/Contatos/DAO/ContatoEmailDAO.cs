using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contatos.Models;

namespace Contatos.DAO
{
    public class ContatoEmailDAO
    {
        public void Create(ContatoEmail email)
        {
            using (var contexto = new EntidadesContatosDB())
            {
                contexto.ContatoEmail.Add(email);
                contexto.SaveChanges();
            }
        }

        public IList<ContatoEmail> Read()
        {
            using (var contexto = new EntidadesContatosDB())
            {
                return contexto.ContatoEmail.Include("TipoEmail").ToList();
            }
        }

        public void Update(ContatoEmail email)
        {
            using (var contexto = new EntidadesContatosDB())
            {
                contexto.Entry(email).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Delete(ContatoEmail email)
        {
            using (var contexto = new EntidadesContatosDB())
            {
                contexto.ContatoEmail.Remove(email);
                contexto.SaveChanges();
            }
        }

        public ContatoEmail GetByID(int Id)
        {
            using (var contexto = new EntidadesContatosDB())
            {
                return contexto.ContatoEmail.Where(c => c.ContatoEmailID == Id).FirstOrDefault();
            }
        }
    }
}