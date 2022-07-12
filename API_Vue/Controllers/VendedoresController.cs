using API_Vue.Models;
using API_Vue.Services;
using Microsoft.AspNetCore.Mvc;
using API_Vue.Models.ViewModels;
using System.Collections.Generic;
using API_Vue.Services.Exceptions;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System;
using System.Threading.Tasks;

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
        public async Task<IActionResult> Index()
        {
            var list = await _vendedorService.FindAllSync();
            return View(list);
        }

        // GET: Vendedores/Create
        public async Task<IActionResult> Create()
        {
            var departamentos = await _departamentoService.FindAllSync();
            var viewModel = new VendedorViewModel { Departamentos = departamentos };
            return View(viewModel);
        }

        // POST: Vendedores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProdutoId, Nome")] Vendedor vendedor)
        {
            if (!ModelState.IsValid) 
            {
                var departments = await _departamentoService.FindAllSync();
                var viewModel = new VendedorViewModel { Vendedor = vendedor, Departamentos = departments };
                return View(viewModel);
            }

            _vendedorService.Insert(vendedor);
            return RedirectToAction(nameof(Index));
        }

        // GET: Vendedores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return RedirectToAction(nameof(Error), new { Message = "Id not provided"});

            var obj = await  _vendedorService.FindByIdAsync(id.Value);
            if (obj == null)
                return RedirectToAction(nameof(Error), new { Message = "Id not found" });

            return View(obj);
        }

        // POST: Vendedores/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                await _vendedorService.RemoveAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (IntegrityException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }

        // GET: Vendedores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return RedirectToAction(nameof(Error), new { Message = "Id not provided" });

            var obj = await _vendedorService.FindByIdAsync(id.Value);
            if (obj == null)
                return RedirectToAction(nameof(Error), new { Message = "Id not found" });

            List<Departamento> departamentos = await _departamentoService.FindAllSync();
            VendedorViewModel vendedorViewModel = new VendedorViewModel { Vendedor = obj, Departamentos = departamentos };
            return View(vendedorViewModel);
        }

        // POST: Vendedores/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(int id, Vendedor vendedor)
        {
            if (id != vendedor.Id)
                return RedirectToAction(nameof(Error), new { Message = "Id mismatch" });

            if (ModelState.IsValid)
            {
                try
                {
                    _vendedorService.UpdateAsync(vendedor);
                }
                catch (ApplicationException e)
                {
                    return RedirectToAction(nameof(Error), new {message = e.Message});
                }
                
                return RedirectToAction(nameof(Index));
            }

            var departaments = await _departamentoService.FindAllSync();
            var viewModel = new VendedorViewModel { Vendedor = vendedor, Departamentos = departaments };
            return View(viewModel);
        }

        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel()
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };

            return View(viewModel);
        }
    }
}
