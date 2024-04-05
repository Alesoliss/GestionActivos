using GestionActivos.Models;
using GestionActivos.Servicios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionActivos.Controllers
{
    public class EmpleadosController : Controller
    {
        private readonly EmpleadoServicio _empleadoServicio;

        public EmpleadosController(EmpleadoServicio empleadoServicio)
        {
            _empleadoServicio = empleadoServicio;
        }

        // GET: DepartamentosController
        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new List<EmpleadosViewmodel>();
                var list = await _empleadoServicio.ObtenerCalculosList();
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public async Task<IActionResult> CalculoListado()
        {
            try
            {
                var model = new EmpleadosViewmodel();
                var empleados = await _empleadoServicio.ObtenerListaEmpleados();

                model.Empleados = empleados;

                return View("PrincipalCalculo", model);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }



        [HttpPost]
        public async Task<IActionResult> CalculoListado(int empleadoId, DateTime fechaInicio, DateTime fechaFinal)
        {
            try
            {
                var list = await _empleadoServicio.ObtenerCalculoList(empleadoId, fechaInicio, fechaFinal);
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }


        //prueba 2
        //public async Task<IActionResult> Index()
        //{
        //    try
        //    {
        //        var empleados = await _empleadoServicio.ObtenerListaEmpleados();
        //        return View(empleados); 
        //    }
        //    catch (Exception ex)
        //    {
        //        return RedirectToAction("Index", "Home");
        //    }
        //}






    }
}