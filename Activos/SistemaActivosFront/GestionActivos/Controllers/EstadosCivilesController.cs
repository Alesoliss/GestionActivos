using GestionActivos.Models;
using GestionActivos.Servicios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionActivos.Controllers
{
    public class EstadosCivilesController : Controller
    {
        public EstadosCivilesServices _estadosCivilesServices;
        public EstadosCivilesController(EstadosCivilesServices estadosCivilesServices)
        {
            _estadosCivilesServices = estadosCivilesServices;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new List<EstadosCivilesViewModel>();
                var list = await _estadosCivilesServices.ObtenerEstadosCivilesList();
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }



        [HttpPost]
        public async Task<IActionResult> Update(EstadosCivilesViewModel item)
        {

            item.EstD_UsuarioModificacion = 1;
            item.EstD_FechaModificacion = DateTime.Now;
            var list = await _estadosCivilesServices.ActualizarEstadoCivil(item);
            if (list.Success)
            {
                TempData["Exito"] = "El Cargo se agrego con exito";
                return RedirectToAction("Index");

            }
            else
            {
                TempData["Error"] = "El Cargo no se pudo agregar";
                return RedirectToAction("Index");

            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(EstadosCivilesViewModel item, int EstD_Id)
        {

            var list = await _estadosCivilesServices.EliminarEstado(item, EstD_Id);
            if (list.Success)
            {
                TempData["Exito"] = "El Cargo se agrego con exito";
                return RedirectToAction("Index");

            }
            else
            {
                TempData["Error"] = "El Cargo no se pudo agregar";
                return RedirectToAction("Index");

            }
        }

        public async Task<IActionResult> Details(int EstD_Id)
        {
            var list = await _estadosCivilesServices.DetallesEstados(EstD_Id);
            if (list.Success)

            {
                try
                {
                    var data = list.Data;

                    return View(data);
                }
                catch (Exception ex)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                return View("Error");
            }
        }
    }
}
