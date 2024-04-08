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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CargosViewModel item)
        {
            try
            {
                item.Carg_UsuarioCreacion = 1;
                item.Carg_FechaCreacion = DateTime.Now;
                var list = await _cargosServicios.CrearCargos(item);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(item);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Update(CargosViewModel item)
        {
            try
            {
                item.Carg_UsuarioModificacion = 1;
                item.Carg_FechaModificacion = DateTime.Now;
                var list = await _cargosServicios.ActualizarCargo(item);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(item);
            }
        }

        [HttpPost]
        public IActionResult Delete(CargosViewModel item, int Carg_Id)
        {
            try
            {
                var list = _cargosServicios.EliminarCargo(item, Carg_Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(item);
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
