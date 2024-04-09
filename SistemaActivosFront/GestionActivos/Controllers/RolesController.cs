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
        private readonly PantallasServicios _pantallasServicios;
        private readonly PantallasPorRolesServicios _pantallasPorRolesServicios;

        public RolesController(RolServicio rolServicio, PantallasPorRolesServicios pantallasPorRolesServicios, PantallasServicios pantallasServicios)
        {
            _rolServicio = rolServicio;
            _pantallasServicios = pantallasServicios;
            _pantallasPorRolesServicios = pantallasPorRolesServicios;
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
        public async Task<IActionResult> Create()
        {

            var model = new List<PantallasViewModel>();
            var list = await _pantallasServicios.ObtenerPantallas();
            ViewBag.ConsultaPantalla = list.Data;

            var listadoPantallasRoles = await _pantallasPorRolesServicios.ObtenerPantallasPorRoles();
            ViewBag.ConsultaPantallaPorRoles = listadoPantallasRoles.Data;
            return View();

            //var listadoPantallas = _pantallasServicios.ObtenerPantallas();
            ////var listadoPant = _mapper.Map<IEnumerable<PantallasViewModel>>(listadoPantallas);

            //return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

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
