using Microsoft.AspNetCore.Mvc;
using SistemasActivos.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionActivos.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index(List<DepartamentosViewmodel> usuarios)
        {
            return View(usuarios);
        }
    }
}
