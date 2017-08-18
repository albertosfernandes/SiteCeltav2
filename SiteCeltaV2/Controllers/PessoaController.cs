using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SiteCeltaV2.Aplicacao;
using SiteCeltaV2.Entities;

namespace SiteCeltaV2.Controllers
{
    public class PessoaController : Controller
    {
        private PessoaAplicacao pessoaAplicacao;
        public PessoaController()
        {
            pessoaAplicacao = new PessoaAplicacao();
        }
        public ActionResult Index()
        {
            var lista = pessoaAplicacao.ListarTodos();
            return View(lista);
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                pessoaAplicacao.Salvar(pessoa);
                return RedirectToAction("Index");
            }
            return View(pessoa);
        }

        public ActionResult Editar(int id)
        {
            var pessoa = pessoaAplicacao.ListarPorId(id);

            if (pessoa == null)
                return HttpNotFound();

            return View(pessoa);
        }

        [HttpPost]
        public ActionResult Editar(Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                pessoaAplicacao.Salvar(pessoa);
                return RedirectToAction("Index");
            }
            return View(pessoa);
        }

        public ActionResult Detalhe(int id)
        {
            var pessoa = pessoaAplicacao.ListarPorId(id);

            if (pessoa == null)
                return HttpNotFound();

            return View(pessoa);
        }

        public ActionResult Excluir(int id)
        {
            var pessoa = pessoaAplicacao.ListarPorId(id);

            if (pessoa == null)
                return HttpNotFound();

            return View(pessoa);
        }

        [HttpPost, ActionName("Excluir")]
        public ActionResult ConfirmarExcluir(int id)
        {
            pessoaAplicacao.Excluir(id);
            return RedirectToAction("Index");
        }
    }
}