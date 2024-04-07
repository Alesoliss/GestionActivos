using GestionActivos.Models;
using GestionActivos.Servicios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionActivos.Controllers
{
    public class RolesController : Controller
    {
        private readonly RolServicio _rolServicio;

        public RolesController(RolServicio rolServicio)
        {
            _rolServicio = rolServicio;
        }

        // GET: RolesController

        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new List<RolesViewModel>();
                var list = await _rolServicio.Listado();
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // POST: RolesController/Crear

        [HttpGet("Roles/Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RolesViewModel item)
        {
            try
            {
                var list = await _rolServicio.CrearRoles(item);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(item);
            }
        }
    }
}
