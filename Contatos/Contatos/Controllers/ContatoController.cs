using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contatos.Models;
using Contatos.DAO;

namespace Contatos.Controllers
{
    public class ContatoController : Controller
    {

        // GET: Contato
        public ActionResult Index(string filtrarNome)
        {
            ContatoDAO dao = new ContatoDAO();
            IList<Contato> contatos = dao.Read();


            if (filtrarNome == "Todos" || filtrarNome == null || filtrarNome == "")
            {
                ViewBag.Contatos = contatos;
            }
            else
            {
                ViewBag.Contatos = contatos.Where(contato => contato.ContatoNome.StartsWith(filtrarNome));
            }

            ContatoTelefoneDAO telefoneDAO = new ContatoTelefoneDAO();
            ViewBag.Telefones = telefoneDAO.Read();

            ContatoEmailDAO emailDAO = new ContatoEmailDAO();
            ViewBag.Emails = emailDAO.Read();

            return View();
        }

        public ActionResult Form(Contato contato, int contatoId)
        {
            string urlActionForm;

            // Retorna o contato
            if (contatoId > 0)
            {
                ContatoDAO dao = new ContatoDAO();
                ViewBag.Contato = dao.GetByID(contatoId);
                urlActionForm = "/Contato/Editar?contatoId=" + contatoId;
            }
            else
            {
                urlActionForm = "/Contato/Adicionar";
            }

            ViewBag.ActionForm = urlActionForm;

            // Retorna os telefones
            TipoTelefoneDAO tipoTelefoneDAO = new TipoTelefoneDAO();
            ViewBag.TiposTelefone = tipoTelefoneDAO.Read();
            ContatoTelefoneDAO telefoneDAO = new ContatoTelefoneDAO();
            IList<ContatoTelefone> telefones = telefoneDAO.Read();
            ViewBag.Telefones = telefones.Where(telefone => telefone.ContatoID == contato.ContatoID);

            // Retorna os emails
            TipoEmailDAO tipoEmailDAO = new TipoEmailDAO();
            ViewBag.TiposEmail = tipoEmailDAO.Read();
            ContatoEmailDAO emailDAO = new ContatoEmailDAO();
            IList<ContatoEmail> emails = emailDAO.Read();
            ViewBag.Emails = emails.Where(email => email.ContatoID == contato.ContatoID);

            return View();
        }

        public ActionResult Adicionar(Contato contato)
        {
            ContatoDAO dao = new ContatoDAO();
            dao.Create(contato);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(Contato contato)
        {
            ContatoDAO dao = new ContatoDAO();
            dao.Update(contato);
            return RedirectToAction("Form", "Contato", new { contatoId = contato.ContatoID });
        }

        public ActionResult Remover(Contato contato)
        {
            ContatoDAO dao = new ContatoDAO();
            dao.Delete(contato);
            return RedirectToAction("Index");
        }
    }
}