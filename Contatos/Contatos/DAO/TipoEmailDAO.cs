using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contatos.Models;

namespace Contatos.DAO
{
    public class TipoEmailDAO
    {
        public IList<TipoEmail> Read()
        {
            using (var contexto = new EntidadesContatosDB())
            {
                return contexto.TipoEmail.ToList();
            }
        }
    }
}