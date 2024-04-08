using GestionActivos.Models;
using GestionActivos.Servicios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionActivos.Controllers
{
    public class CargosController : Controller
    {
        public CargosServicios _cargosServicios;

        public CargosController(CargosServicios cargosServicios)
        {
            _cargosServicios = cargosServicios;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new List<CargosViewModel>();
                var list = await _cargosServicios.Listado();
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
