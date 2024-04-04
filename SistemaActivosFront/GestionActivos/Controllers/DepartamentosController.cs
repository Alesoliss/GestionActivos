using GestionActivos.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SistemasActivos.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionActivos.Controllers
{
    public class DepartamentosController : Controller
    {
        public DepartamentoServicios _departamentoServicios;
        public DepartamentosController(DepartamentoServicios departamentoServicios)
        {
            _departamentoServicios = departamentoServicios;
        }
        // GET: DepartamentosController
        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new List<DepartamentosViewmodel>();
                var list = await _departamentoServicios.ObtenerDepartamentoList();
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartamentosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DepartamentosViewmodel item)
        {
            try
            {
                item.Depa_UsuarioCreacion = 1;
                item.Depa_FechaCreacion = DateTime.Now;
                var list = await _departamentoServicios.CrearDepartamento(item);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(item);
            }
        }
    }
}
