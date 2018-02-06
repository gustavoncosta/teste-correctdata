using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contatos.Models;
using Contatos.DAO;

namespace Contatos.Controllers
{
    public class TelefoneController : Controller
    {
        // GET: Telefone
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Adicionar(ContatoTelefone telefone, int contatoId)
        {
            ContatoTelefoneDAO dao = new ContatoTelefoneDAO();
            telefone.ContatoID = contatoId;
            dao.Create(telefone);
            return RedirectToAction("Form", "Contato", new { contatoId = telefone.ContatoID });
        }

        public ActionResult Remover(int contatoTelefoneId)
        {
            ContatoTelefoneDAO dao = new ContatoTelefoneDAO();
            var telefone = dao.GetByID(contatoTelefoneId);
            dao.Delete(telefone);
            return RedirectToAction("Form", "Contato", new { contatoId = telefone.ContatoID });
        }
    }
}