using GestionActivos.Servicios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionActivos.Controllers
{
    public class MunicipiosController : Controller
    {
        public MunicipiosServicios _municipiosServicios;
        public MunicipiosController(MunicipiosServicios municipiosServicios)
        {
            _municipiosServicios = municipiosServicios;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new List<MunicipiosServicios>();
                var list = await _municipiosServicios.ObtenerMunicipioList();
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
