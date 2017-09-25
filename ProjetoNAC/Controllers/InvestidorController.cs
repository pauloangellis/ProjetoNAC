using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoNAC.Models;

namespace ProjetoNAC.Controllers
{
    public class InvestidorController : Controller
    {
        // GET: Investidor
        public ActionResult Investidor()
        {
            return View();
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Investidor i)
        {
            Repositorio.Instance().IncluirInvestidor(i);
            return RedirectToAction("Listar");
        }

        public ActionResult Listar()
        {
            var investidores = Repositorio.Instance().ListarInvestidores();
            return View(investidores);
        }

        public ActionResult Excluir(int id)
        {
            Repositorio.Instance().ExcluirInvestidor(id);
            return RedirectToAction("Listar");
        }

        public ActionResult Editar(int id)
        {
            var investidor = Repositorio.Instance().ListarInvestidor(id);
            return View("Cadastrar", investidor);
        }
        [HttpPost]
        public ActionResult Editar(Investidor i)
        {
            Repositorio.Instance().AlterarInvestidor(i);
            return RedirectToAction("Listar");
        }

    }
}