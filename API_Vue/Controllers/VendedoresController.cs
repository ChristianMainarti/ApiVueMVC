using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Vue.Controllers
{
    public class VendedoresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
