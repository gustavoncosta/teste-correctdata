using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contatos.Models;
using Contatos.DAO;

namespace Contatos.Controllers
{
    public class EmailController : Controller
    {
        // GET: Email
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Adicionar(ContatoEmail email, int contatoId)
        {
            ContatoEmailDAO dao = new ContatoEmailDAO();
            email.ContatoID = contatoId;
            dao.Create(email);
            return RedirectToAction("Form", "Contato", new { contatoId = email.ContatoID });
        }

        public ActionResult Remover(int contatoEmailId)
        {
            ContatoEmailDAO dao = new ContatoEmailDAO();
            var email = dao.GetByID(contatoEmailId);
            dao.Delete(email);
            return RedirectToAction("Form", "Contato", new { contatoId = email.ContatoID });
        }
    }
}