using API_Vue.Models;
using API_Vue.Services;
using Microsoft.AspNetCore.Mvc;
using API_Vue.Models.ViewModels;
using System.Collections.Generic;
using API_Vue.Services.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace API_Vue.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedorService _vendedorService;
        private readonly DepartamentoService _departamentoService;
        public VendedoresController(VendedorService vendedorService, DepartamentoService departamentoService)
        {
            _vendedorService = vendedorService;
            _departamentoService = departamentoService;
        }

        // GET: Vendedores
        public IActionResult Index()
        {
            var list = _vendedorService.FindAll();
            return View(list);
        }

        // GET: Vendedores/Create
        public IActionResult Create()
        {
            var departamentos = _departamentoService.FindAll();
            var viewModel = new VendedorViewModel { Departamentos = departamentos };
            return View(viewModel);
        }

        // POST: Vendedores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("ProdutoId, Nome")] Vendedor vendedor)
        {
            _vendedorService.Insert(vendedor);
            return RedirectToAction(nameof(Index));
        }

        // GET: Vendedores/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var obj = _vendedorService.FindById(id.Value);
            if (obj == null)
                return NotFound();

            return View(obj);
        }

        // POST: Vendedores/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {


            _vendedorService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        // GET: Vendedores/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var obj = _vendedorService.FindById(id.Value);
            if (obj == null)
                return NotFound();

            List<Departamento> departamentos = _departamentoService.FindAll();
            VendedorViewModel vendedorViewModel = new VendedorViewModel { Vendedor = obj, Departamentos = departamentos };
            return View(vendedorViewModel);
        }

        // POST: Vendedores/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Edit(int id, Vendedor vendedor)
        {
            if (id != vendedor.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _vendedorService.Update(vendedor);
                }
                catch (NotFoundException e)
                {
                    throw new NotFoundException(e.Message);
                }
                catch (DbUpdateConcurrencyException)
                {
                    return BadRequest();
                }
                return RedirectToAction(nameof(Index));
            }
            return View(vendedor);
        }
    }
}
