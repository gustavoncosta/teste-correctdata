using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contatos.Models;

namespace Contatos.DAO
{
    public class TipoTelefoneDAO
    {
        public IList<TipoTelefone> Read()
        {
            using (var contexto = new EntidadesContatosDB())
            {
                return contexto.TipoTelefone.ToList();
            }
        }
    }
}