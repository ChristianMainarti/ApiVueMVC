using API_Vue.Models;
using API_Vue.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Vue.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedorService _vendedorService;
        public VendedoresController(VendedorService vendedorService)
        {
            _vendedorService = vendedorService;
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
            return View();
        }

        // POST: Vendedores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("ProdutoId, Nome")] Vendedor vendedor)
        {
            if (ModelState.IsValid)
            {
                _vendedorService.Insert(vendedor);
                return RedirectToAction(nameof(Index));
            }

            return View(vendedor);
        }
    }
}
