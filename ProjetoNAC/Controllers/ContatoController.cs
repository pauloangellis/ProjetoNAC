using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoNAC.Models;

namespace ProjetoNAC.Controllers
{
    public class ContatoController : Controller
    {
        // GET: Contato
        public ActionResult Contato()
        {

            return View();
        }
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Contato c)
        {
            Repositorio.Instance().IncluirContato(c);
            return RedirectToAction("Listar");
        }

        public ActionResult Listar()
        {
            var contatos = Repositorio.Instance().ListarContatos();
            return View(contatos);
        }

        public ActionResult Excluir(int id)
        {
            Repositorio.Instance().ExcluirContato(id);
            return RedirectToAction("Listar");
        }

        public ActionResult Editar(int id)
        {
            var contato = Repositorio.Instance().ListarContato(id);
            return View("Cadastrar", contato);
        }
        [HttpPost]
        public ActionResult Editar(Contato c)
        {
            Repositorio.Instance().AlterarContato(c);
            return RedirectToAction("Listar");
        }
    }
}