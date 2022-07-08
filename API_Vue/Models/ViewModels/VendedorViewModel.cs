using System;
using System.Collections.Generic;
using System.Linq;

namespace API_Vue.Models.ViewModels
{
    public class VendedorViewModel
    {
        public Vendedor Vendedor { get; set; }
        public ICollection<Departamento> Departamentos { get; set; }
    }
}
