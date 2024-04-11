using GestionActivos.Models;
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
    public class MunicipiosController : Controller
    {
        public MunicipiosServicios _municipiosServicios;
        public DepartamentoServicios _departamentoServicios;
        public MunicipiosController(MunicipiosServicios municipiosServicios, DepartamentoServicios departamentoServicios)
        {
            _municipiosServicios = municipiosServicios;
            _departamentoServicios = departamentoServicios;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new List<MunicipiosServicios>();
                var list = await _municipiosServicios.ObtenerMunicipioList();
                
                var depadl = await _departamentoServicios.ObtenerDepartamentoList();
                if (depadl.Success)
                {
                    var cliente = depadl.Data as List<DepartamentosViewmodel>;

                    var clientelist = cliente.Select(x => new SelectListItem { Text = x.Depa_Descripcion, Value = x.Depa_Codigo.ToString() }).ToList();
                    clientelist.Insert(0, new SelectListItem { Text = "-- SELECCIONE --", Value = "" });

                    ViewBag.Departa = clientelist;
                }
                else
                {
                    // Manejar el error si falla la obtención de departamentos
                    return View("Error");
                }
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MunicipiosViewModel item)
        {

            var list = await _municipiosServicios.CrearCategoria(item);
            if (list.Success)
            {
                TempData["Exito"] = "El Municipio se agrego con exito";
                return RedirectToAction("Index");

            }
            else
            {
                TempData["Error"] = "El Municipio no se pudo agregar";
                return RedirectToAction("Index");

            }
        }

        [HttpPost]
        public async Task<IActionResult> Update(MunicipiosViewModel item)
        {

            var list = await _municipiosServicios.ActualizarMunicipio(item);
            if (list.Success)
            {
                TempData["Exito"] = "El Municipio se agrego con exito";
                return RedirectToAction("Index");

            }
            else
            {
                TempData["Error"] = "El Municipio no se pudo agregar";
                return RedirectToAction("Index");

            }
        }

        [HttpPost]
        public IActionResult Delete(MunicipiosViewModel item, string Muni_Codigo)
        {
            try
            {
                var list = _municipiosServicios.EliminarMunicipio(item, Muni_Codigo);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(item);
            }
        }

        public async Task<IActionResult> Details(string Muni_codigo)
        {
            var list = await _municipiosServicios.DetallesDepartamento(Muni_codigo);
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
