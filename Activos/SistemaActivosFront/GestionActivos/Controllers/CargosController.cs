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
                var model = new CargosViewModel();
                var list = await _cargosServicios.Listado();
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CargosViewModel item)
        {
           
                item.Carg_UsuarioCreacion = 1;
                item.Carg_FechaCreacion = DateTime.Now;
                var list = await _cargosServicios.CrearCargos(item);
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
        public async Task<IActionResult> Update(CargosViewModel item)
        {
            
                item.Carg_UsuarioModificacion = 1;
                item.Carg_FechaModificacion = DateTime.Now;
                var list = await _cargosServicios.ActualizarCargo(item);
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
        public async Task<IActionResult> Delete(CargosViewModel item, int Carg_Id)
        {

            var list = await _cargosServicios.EliminarCargo(item, Carg_Id);
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

        //GET: CargosController/Detalles
        public async Task<IActionResult> Details(int Carg_Id)
        {
            var list = await _cargosServicios.Detalles(Carg_Id);
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
                return RedirectToAction("Index");
            }
        }
    }
}
