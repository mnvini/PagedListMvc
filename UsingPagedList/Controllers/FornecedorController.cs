using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsingPagedList.Models;
using PagedList;
namespace UsingPagedList.Controllers
{
    public class FornecedorController : Controller
    {
        private readonly PaginationContext _db = new PaginationContext();
        public ActionResult Index(int? pagina)
        {
            int qtdeItensPagina = 10;
            int numeroPagina = (pagina ?? 1);

            var listaFornecedor = _db.Fornecedores.ToList();

            return View(listaFornecedor.ToPagedList(numeroPagina, qtdeItensPagina));
        }

        public ActionResult Editar(int? id)
        {
            return View(_db.Fornecedores.Find(id));
        }
        [HttpPost]
        public ActionResult Editar(Fornecedor fornecedor)
        {
            _db.Fornecedores.Attach(fornecedor);
            _db.Entry(fornecedor).State = EntityState.Modified;
            _db.SaveChanges();

            return RedirectToAction("Index", "Fornecedor");
        }


        public JsonResult Remover(int id)
        {
            var fornecedor = new Fornecedor { Id = id };
            _db.Fornecedores.Attach(fornecedor);
            _db.Fornecedores.Remove(fornecedor);
            _db.SaveChanges();

            var teste = _db.Fornecedores.ToList();
            return Json(new { dados = teste }, JsonRequestBehavior.AllowGet);
        }


        public ActionResult Adicionar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Adicionar(Fornecedor fornecedor)
        {
            fornecedor.DataCadastro = DateTime.Now;
            _db.Fornecedores.Add(fornecedor);
            _db.SaveChanges();

            return RedirectToAction("Index", "Fornecedor");
        }

    }
}