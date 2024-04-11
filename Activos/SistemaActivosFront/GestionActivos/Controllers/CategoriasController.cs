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
    public class CategoriasController : Controller
    {
        public CategoriasService _categoriasService;
        public CategoriasController(CategoriasService categoriasService)
        {
            _categoriasService = categoriasService;
        }
        // GET: CategoriasController
        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new List<CategoriasViewmodel>();
                var list = await _categoriasService.ObtenerCategoriaList();
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
        public async Task<IActionResult> Create(CategoriasViewmodel item)
        {

            item.Cate_UsuarioCreacion = 1;
            item.Cate_FechaCreacion = DateTime.Now;
            var list = await _categoriasService.CrearCategoria(item);
            if (list.Success)
            {
                TempData["Exito"] = "El Categoria se agrego con exito";
                return RedirectToAction("Index");

            }
            else
            {
                TempData["Error"] = "El Categoria no se pudo agregar";
                return RedirectToAction("Index");

            }
        }
        [HttpGet("Categorias/llenar/{Cate_Id}")]
        public async Task<IActionResult> llenar(CategoriasViewmodel item, int Cate_Id)
        {
            try
            {
                var list = await _categoriasService.LlenarCategoria(Cate_Id);
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return View(item);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Update(CategoriasViewmodel item)
        {

            item.Cate_UsuarioModificacion = 1;
            item.Cate_FechaModificacion = DateTime.Now;
            var list = await _categoriasService.ActualizarCategoria(item);
            if (list.Success)
            {
                TempData["Exito"] = "El Categoria se agrego con exito";
                return RedirectToAction("Index");

            }
            else
            {
                TempData["Error"] = "El Categoria no se pudo agregar";
                return RedirectToAction("Index");

            }
        }


        [HttpPost]
        public async Task<IActionResult> Delete(CategoriasViewmodel item, int Cate_Id)
        {

            var list = await _categoriasService.Eliminarcategoria(item, Cate_Id);
            if (list.Success)
            {
                TempData["Exito"] = "El Categoria se agrego con exito";
                return RedirectToAction("Index");

            }
            else
            {
                TempData["Error"] = "El Categoria no se pudo agregar";
                return RedirectToAction("Index");

            }
        }

        //GET: CategoriasController/Details
        public async Task<IActionResult> Details(int Cate_Id, CategoriasViewmodel item)
        {
            var list = await _categoriasService.DetallesCategoria(Cate_Id);
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
