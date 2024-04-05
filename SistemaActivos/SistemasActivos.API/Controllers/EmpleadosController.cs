using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SistemaActivos.Common.Model;
using SistemaActivos.Entities.Entities;
using SistemaDeActivos.BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemasActivos.API.Controllers
{
    [ApiController]
    [Route("/API/[controller]")]
    public class EmpleadosController : Controller
    {
        private readonly ActiveService _activeService;

        public EmpleadosController(ActiveService activeService)
        {
            _activeService = activeService;
        }



        [HttpGet("Listado")]

        public IActionResult Index()
        {

            var listado = _activeService.Listado();

            return Ok(listado);
        }





        [HttpGet("listadoActivos")]
        public IActionResult ListadoActivos(int id, DateTime f1, DateTime f2)
        {
            var result = _activeService.ListadoActivos(id, f1, f2);

            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return StatusCode(500, new { message = result.Message });
            }
        }



        //[HttpGet("listadoActivos")]
        //public IActionResult ListadoGeneral()
        //{
        //    var result = _activeService.ListadoGeneral();

        //    if (result.Success)
        //    {
        //        return Ok(result.Data);
        //    }
        //    else
        //    {
        //        return StatusCode(500, new { message = result.Message });
        //    }
        //}


        [HttpGet("listaEmpleados")]
        public async Task<IActionResult> ListaEmpleados()
        {
            var result = await _activeService.ObtenerListaEmpleadosDesdeBaseDeDatos();

            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return StatusCode(500, new { message = result.Message });
            }
        }




    }
}