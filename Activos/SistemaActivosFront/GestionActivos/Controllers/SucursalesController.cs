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
    public class SucursalesController : Controller
    {
        public DepartamentoServicios _departamentoServicios;
        public MunicipiosServicios _municipiosServicios;
        public SucursalesServices _sucursalesServices;
        public SucursalesController(SucursalesServices sucursalesServices, DepartamentoServicios departamentoServicios, MunicipiosServicios municipiosServicios)
        {
            _departamentoServicios = departamentoServicios;
            _sucursalesServices = sucursalesServices;
            _municipiosServicios = municipiosServicios;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new List<SucursalesViewModel>();
                var list = await _sucursalesServices.ObtenerSucursalesList();

                var depadl = await _departamentoServicios.ObtenerDepartamentoList();
                var munidl = await _municipiosServicios.ObtenerMunicipioList();
                if ((depadl.Success) && (munidl.Success))
                {
                    var depar = depadl.Data as List<DepartamentosViewmodel>;
                    var muni = munidl.Data as List<MunicipiosViewModel>;

                    var clientelist = depar.Select(x => new SelectListItem { Text = x.Depa_Descripcion, Value = x.Depa_Codigo.ToString() }).ToList();
                    clientelist.Insert(0, new SelectListItem { Text = "-- SELECCIONE --", Value = "" });
                    ViewBag.Departa = clientelist;

                    var munilist = muni.Select(x => new SelectListItem { Text = x.Muni_Descripcion, Value = x.Muni_Codigo.ToString() }).ToList();
                    munilist.Insert(0, new SelectListItem { Text = "--SELECCIONE--", Value = "" });
                    ViewBag.Munici = munilist;
                }
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public async Task <ActionResult> Create()
        {
            var depadl = await _departamentoServicios.ObtenerDepartamentoList();
            var munidl = await _municipiosServicios.ObtenerMunicipioList();
            if ((depadl.Success) && (munidl.Success))
            {
                var depar = depadl.Data as List<DepartamentosViewmodel>;
                var muni = munidl.Data as List<MunicipiosViewModel>;

                var clientelist = depar.Select(x => new SelectListItem { Text = x.Depa_Descripcion, Value = x.Depa_Codigo.ToString() }).ToList();
                clientelist.Insert(0, new SelectListItem { Text = "-- SELECCIONE --", Value = "" });
                ViewBag.Departa = clientelist;

                var munilist = muni.Select(x => new SelectListItem { Text = x.Muni_Descripcion, Value = x.Muni_Codigo.ToString() }).ToList();
                munilist.Insert(0, new SelectListItem { Text = "--SELECCIONE--", Value = "" });
                ViewBag.Munici = munilist;
            }
            return View();
        }

        // POST: DepartamentosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SucursalesViewModel item)
        {
            item.Sucu_UsuarioCreacion = 1;
            item.Sucu_FechaCreacion = DateTime.Now;
            var list = await _sucursalesServices.CrearSucursal(item);
            if (list.Success)
            {
                TempData["Exito"] = "El Departamento se agrego con exito";
                return RedirectToAction("Index");

            }
            else
            {
                TempData["Error"] = "El Departamento no se pudo agregar";
                return RedirectToAction("Index");

            }

        }

        [HttpGet("Departamentos/llenar/{Depa_Codigo}")]
        public async Task<IActionResult> llenar(SucursalesViewModel item, int Sucu_Id)
        {
            try
            {
                var list = await _sucursalesServices.LlenarSucursal(Sucu_Id);
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return View(item);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Update(SucursalesViewModel item)
        {

            var list = await _sucursalesServices.ActualizarSucursal(item);
            if (list.Success)
            {
                TempData["Exito"] = "El Departamento se agrego con exito";
                return RedirectToAction("Index");

            }
            else
            {
                TempData["Error"] = "El Departamento no se pudo agregar";
                return RedirectToAction("Index");

            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(SucursalesViewModel item, int Sucu_Id)
        {

            var list = await _sucursalesServices.EliminarSucursal(item, Sucu_Id);
            if (list.Success)
            {
                TempData["Exito"] = "El Departamento se agrego con exito";
                return RedirectToAction("Index");

            }
            else
            {
                TempData["Error"] = "El Departamento no se pudo agregar";
                return RedirectToAction("Index");

            }
        }

        public async Task<IActionResult> Details(int Sucu_Id)
        {
            var list = await _sucursalesServices.DetallesSucursal(Sucu_Id);
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
