﻿using GestionActivos.Servicios;
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
            
                item.Depa_UsuarioCreacion = 1;
                item.Depa_FechaCreacion = DateTime.Now;
                var list = await _departamentoServicios.CrearDepartamento(item);
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

        [HttpGet ("Departamentos/llenar/{Depa_Codigo}")]
        public async Task<IActionResult> llenar(DepartamentosViewmodel item, string Depa_Codigo)
        {
            try
            {
                var list = await _departamentoServicios.LlenarDepartamento(Depa_Codigo);
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return View(item);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Update(DepartamentosViewmodel item)
        {
            
            item.Depa_UsuarioModificacion = 1;
            item.Depa_FechaModificacion = DateTime.Now;
            var list = await _departamentoServicios.ActualizarDepartamento(item);
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
        public async Task<IActionResult> Delete(DepartamentosViewmodel item, string Depa_Codigo)
        {

            var list = await _departamentoServicios.EliminarDepartamento(item, Depa_Codigo);
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

        //GET: DepartamentosController/Details
        public async Task<IActionResult> Details(string Depa_Codigo )
        {
            var list = await _departamentoServicios.DetallesDepartamento(Depa_Codigo);
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
