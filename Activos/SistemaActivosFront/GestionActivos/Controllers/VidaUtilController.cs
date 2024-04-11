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
    public class VidaUtilController : Controller
    {
        public VidaUtilService _vidaUtilService;
        public CategoriasService _categoriasService;
        public VidaUtilController(VidaUtilService vidaUtilService, CategoriasService categoriasService)
        {
            _vidaUtilService = vidaUtilService;
            _categoriasService = categoriasService;

        }
        // GET: DepartamentosController
        public async Task<IActionResult> Index()
        {

            try
            {
                var model = new List<VidaUtilViewmodel>();
                var list = await _vidaUtilService.ObtenerVidaList();

                var catedl = await _categoriasService.ObtenerCategoriaList();
                if (catedl.Success)
                {
                    var cate = catedl.Data as List<CategoriasViewmodel>;

                    var categorialist = cate.Select(x => new SelectListItem { Text = x.Cate_Descripcion, Value = x.Cate_Id.ToString() }).ToList();
                    categorialist.Insert(0, new SelectListItem { Text = "-- SELECCIONE --", Value = "" });

                    ViewBag.Categori = categorialist;
                }
                else
                {
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
        public async Task<IActionResult> Create(VidaUtilViewmodel item)
        {
            try
            {
                item.VidU_UsuarioCreacion = 1;
                item.VidU_FechaCreacion = DateTime.Now;
                var list = await _vidaUtilService.CrearVida(item);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(item);
            }
        }
        [HttpGet("Categorias/llenar/{VidU_Id}")]
        public async Task<IActionResult> llenar(VidaUtilViewmodel item, int VidU_Id)
        {
            try
            {
                var list = await _vidaUtilService.LlenarVida(VidU_Id);
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return View(item);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Update(VidaUtilViewmodel item)
        {
            try
            {
                item.VidU_UsuarioCreacion = 1;
                item.VidU_FechaModificacion = DateTime.Now;
                var list = await _vidaUtilService.ActualizarVida(item);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(item);
            }
        }


        [HttpPost]
        public IActionResult Delete(VidaUtilViewmodel item, int VidU_Id)
        {
            try
            {
                var list = _vidaUtilService.EliminarVida(item, VidU_Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(item);
            }
        }

        public async Task<IActionResult> Details(int VidU_Id, VidaUtilViewmodel item)
        {
            var list = await _vidaUtilService.DetallesVida(VidU_Id);
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
