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
        public ActionResult Index(string filtro)
        {
            var vm = _veiculoAplicacao.Listar(filtro).Select(x => new VeiculoViewModel(x));
            if (vm.Count() == 0 && !string.IsNullOrEmpty(filtro))
            {
                var message = string.Format("Chassi: {0} não está cadastrado no sistema", filtro);
                ModelState.AddModelError(string.Empty, message);
            }

            return View(vm);
        }        

        // GET: Veiculo/Details/5
        public ActionResult Details(int id)
        {
            var viewModel = new VeiculoViewModel(_veiculoAplicacao.ListarPorId(id));
            return View(viewModel);
        }

        // GET: Veiculo/Create
        public ActionResult Create()
        {
            var viewModel = new VeiculoViewModel();
            return View(viewModel);
        }

        // POST: Veiculo/Create
        [HttpPost]
        public ActionResult Create(VeiculoViewModel viewModel)
        {
            try
            {
                _veiculoAplicacao.Adicionar(viewModel.CriarVeiculo(viewModel.Chassi, viewModel.Cor, viewModel.TipoVeiculo));
                return RedirectToAction("Index");
            }
            catch(InvalidOperationException ex)
            {
                var message = string.Format("Chassi: {0} já cadastrado no sistema.", viewModel.Chassi);
                ModelState.AddModelError(string.Empty, message);
                return View();
            }
            catch (Exception)
            {
                var message = "Ocorreu algum erro para cadastrar o veículo.";
                ModelState.AddModelError(string.Empty, message);
                return View();
            }
        }

        // GET: Veiculo/Edit/5
        public ActionResult Edit(int id)
        {
            var viewModel = new VeiculoViewModel(_veiculoAplicacao.ListarPorId(id));
            return View(viewModel);
        }

        // POST: Veiculo/Edit/5
        [HttpPost]
        public ActionResult Edit(VeiculoViewModel viewModel)
        {
            try
            {
                _veiculoAplicacao.Editar(viewModel.DominioMap());
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
            var viewModel = new VeiculoViewModel(_veiculoAplicacao.ListarPorId(id));
            return View(viewModel);
        }

        // POST: Veiculo/Delete/5
        [HttpPost]
        public ActionResult Delete(VeiculoViewModel viewModel)
        {
            try
            {
                _veiculoAplicacao.Remover(viewModel.Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
