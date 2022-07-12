using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Vue.Services;

namespace API_Vue.Controllers
{
    public class RegistroVendasController : Controller
    {
        private readonly RegistroVendaService _registroVendaService;

        public RegistroVendasController(RegistroVendaService registroVendaService) 
        {
            _registroVendaService = registroVendaService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SimpleSearch(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
                minDate = new DateTime(DateTime.Now.Year, 1, 1);

            if (!maxDate.HasValue)
                maxDate = DateTime.Now;

            ViewData[""] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData[""] = maxDate.Value.ToString("yyyy-MM-dd");

            var result = await _registroVendaService.FindByDateAsync(minDate, maxDate);
            return View(result);
        }

        public IActionResult GroupSearch()
        {
            return View();
        }
    }
}
