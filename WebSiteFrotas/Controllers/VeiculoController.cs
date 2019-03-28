using DominioFrotas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteFrotas.ViewModels;

namespace WebSiteFrotas.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly IVeiculoAplicacao _veiculoAplicacao;
        public VeiculoController(IVeiculoAplicacao veiculoAplicacao)
        {
            _veiculoAplicacao = veiculoAplicacao;
        }
        // GET: Veiculo
        public ActionResult Index()
        {
            var vm = _veiculoAplicacao.Listar().Select(x => new VeiculoViewModel(x));
            return View(vm);
        }        

        // GET: Veiculo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Veiculo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Veiculo/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Veiculo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Veiculo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Veiculo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Veiculo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
