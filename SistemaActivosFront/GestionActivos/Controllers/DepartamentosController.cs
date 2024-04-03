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
    public class DepartamentosController : Controller
        //cambiaaaaaar
    {
        private readonly DepartamentoServicios _activitiesServices;
   

        public DepartamentosController(DepartamentoServicios generalService)
        {
            _activitiesServices = generalService;

        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                string token = HttpContext.User.FindFirst("Token").Value;
                var type = await _activitiesServices.TypesActivitiesList();
                    IEnumerable<DepartamentosViewmodel> data_type = (IEnumerable<DepartamentosViewmodel>)type.Data;
                ViewBag.TiAc_ID = new SelectList(data_type, "ID", "Descripcion");
                var model = new List<DepartamentosViewmodel>();
                var list = await _activitiesServices.ActivityList(token);

                return View(list.Data);
            }
            catch(Exception)
            {
                return RedirectToAction("Error", "Home");
            }
        }
    }
}
