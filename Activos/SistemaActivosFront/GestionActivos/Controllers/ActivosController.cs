using GestionActivos.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaActivos.Common.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GestionActivos.Controllers
{
    public class ActivosController : Controller
    {
        public ActivosServicios _activosServicios;
        public ActivosController(ActivosServicios activosServicios)
        {
            _activosServicios = activosServicios;
        }
        // GET: DepartamentosController
        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new List<ActivosViewmodel>();
                var list = await _activosServicios.ObtenerActivosList();
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
        public async Task<IActionResult> Create(ActivosViewmodel item, IFormFile image)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (image != null && image.Length > 0)
                    {
                        var fileName = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);
                        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", fileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await image.CopyToAsync(stream);
                        }

                        var imageUrl = "/uploads/" + fileName;
                        item.Acti_Url = imageUrl;

                    }

                    item.Acti_UsuarioCreacion = 1;
                    item.Acti_FechaCreacion = DateTime.Now;

                    var result = await _activosServicios.CrearActivo(item);

                    if (result.Success)
                    {
                        TempData["SuccessMessage"] = "¡Activo creado correctamente!";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["ErrorMessage"] = result.Message;
                    }
                }
                else
                {
                    TempData["ErrorMessage"] = "Por favor, completa todos los campos correctamente.";
                }
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Ocurrió un error al intentar crear el activo.";
            }

            return View(item);
        }

        [HttpGet("/API/Activo/LlenarActivo/{Acti_Id}")]
        public async Task<IActionResult> llenar(ActivosViewmodel item, int Acti_Id)
        {
            try
            {
                var list = await _activosServicios.LLenarActivos(Acti_Id);
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return View(item);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Update(ActivosViewmodel item)
        {
            try
            {
                item.Acti_UsuarioModificacion = 1;
                item.Acti_FechaModificacion = DateTime.Now;
                var list = await _activosServicios.ActualizarActivos(item);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(item);
            }
        }


        [HttpPost]
        public IActionResult Delete(ActivosViewmodel item, int Acti_Id)
        {
            try
            {
                var list = _activosServicios.EliminarActivos(item, Acti_Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(item);
            }
        }

        //GET: DepartamentosController/Details
        public async Task<IActionResult> Details(int Acti_Id, ActivosViewmodel item)
        {
            var list = await _activosServicios.DetallesActivos(Acti_Id);
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


        //protected void btnIrAGrafico_Click(object sender, EventArgs e)
        //{
        //}

        public ActionResult Grafico()
        {
            return View("Grafico");

        }

    }
}

