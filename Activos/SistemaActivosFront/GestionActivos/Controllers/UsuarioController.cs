using GestionActivos.Models;
using GestionActivos.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaActivos.Common.Model;
using SistemasActivos.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GestionActivos.Controllers
{
    public class UsuarioController : Controller
    {
        public UsuariosService _usuariosService;
        public RolServicio _rolServicio;
        public EmpleadoServicio _empleadoServicio;
        public UsuarioController(UsuariosService usuariosService, RolServicio rolServicio, EmpleadoServicio empleadoServicio)
        {
            _usuariosService = usuariosService;
            _rolServicio = rolServicio;
            _empleadoServicio = empleadoServicio;
        }
        // GET: UsuarioController
        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new List<UsuariosViewmodel>();
                var list = await _usuariosService.ObtenerUsuariosList();

                var empdl = await _empleadoServicio.ObtenerListaEmpleados1();
                var emple = empdl.Data as List<EmpleadosViewmodel>;
                var empleadolist = emple.Select(x => new SelectListItem { Text = x.nombre, Value = x.Empl_Id.ToString() }).ToList();
                empleadolist.Insert(0, new SelectListItem { Text = "-- SELECCIONE --", Value = "" });
                ViewBag.empleado = empleadolist;

                var roldl = await _rolServicio.Listado();
                var role = roldl.Data as List<RolesViewModel>;
                var rolelist = role.Select(x => new SelectListItem { Text = x.Role_Descripcion, Value = x.Role_Id.ToString() }).ToList();
                rolelist.Insert(0, new SelectListItem { Text = " -- SELECCIONE --", Value = "" });
                ViewBag.Roles = rolelist;
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
        public async Task<IActionResult> Create(UsuariosViewmodel item)
        {
            bool? Usua_Admin = item.Usua_Admin;


            item.Usua_UsuarionCreacion = 1;
            item.Usua_FechaCreacion = DateTime.Now;
            var list = await _usuariosService.CrearUsuario(item);
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



        [HttpGet("usuarios/llenar/{Usua_Id}")]
        public async Task<IActionResult> llenar(UsuariosViewmodel item, int Usua_Id)
        {
            try
            {
                var list = await _usuariosService.LlenarUsuario(Usua_Id);
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return View(item);
            }
        }


        [HttpPost]
        public async Task<IActionResult> Update(UsuariosViewmodel item)
        {

            item.Usua_UsuarionModificacion = 1;
            item.Usua_FechaModificacion = DateTime.Now;
            var list = await _usuariosService.ActualizarUsuario(item);
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
        public async Task<IActionResult> ReestablecerContra(UsuariosViewmodel item)
        {

            var list = await _usuariosService.Reestablecer(item);
            if (list.Success)
            {
                TempData["Exito"] = "La contraseña se cambio con exito";
                return RedirectToAction("Index");

            }
            else
            {
                TempData["Error"] = "No se pudo reestablecer contraseña ";
                return RedirectToAction("Index");

            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(UsuariosViewmodel item, int Usua_Id)
        {

            var list = await _usuariosService.EliminarUsuario(item, Usua_Id);
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

        public async Task<IActionResult> Details(int Usua_Id)
        {
            var list = await _usuariosService.DetallesUsuario(Usua_Id);
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
