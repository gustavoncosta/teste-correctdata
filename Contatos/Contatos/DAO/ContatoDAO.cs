using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contatos.Models;

namespace Contatos.DAO
{
    public class ContatoDAO
    {
        public void Create(Contato contato)
        {
            using (var contexto = new EntidadesContatosDB())
            {
                contexto.Contato.Add(contato);
                contexto.SaveChanges();
            }
        }

        public IList<Contato> Read()
        {
            using (var contexto = new EntidadesContatosDB())
            {
                return contexto.Contato.ToList();
            }
        }

        public void Update(Contato contato)
        {
            using (var contexto = new EntidadesContatosDB())
            {
                contexto.Entry(contato).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Delete(Contato contato)
        {
            using (var contexto = new EntidadesContatosDB())
            {
                contexto.Contato.Remove(contato);
                contexto.SaveChanges();
            }
        }

        public Contato GetByID(int Id)
        {
            using (var contexto = new EntidadesContatosDB())
            {
                return contexto.Contato.Where(c => c.ContatoID == Id).FirstOrDefault();
            }
        }
    }
}