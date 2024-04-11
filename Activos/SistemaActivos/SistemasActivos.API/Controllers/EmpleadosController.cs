using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SistemaActivos.Common.Model;
using SistemaActivos.Entities.Entities;
using SistemaDeActivos.BusinessLogic;
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
        private readonly GeneralServices _generalServices;
        private readonly IMapper _mapper;

        public EmpleadosController(GeneralServices generalServices, IMapper mapper, ActiveService activeService)
        {
            _generalServices = generalServices;
            _mapper = mapper;
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

        [HttpGet("listaEmpleados1")]
        public IActionResult ListaEmpleados1()
        {
            var result = _activeService.ObtenerListaEmpleadosDesdeBaseDeDatos1();

            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return StatusCode(500, new { message = result.Message });
            }
        }

        [HttpPost("Create")]
        public IActionResult Create(EmpleadosViewmodel item)
        {
            var model = _mapper.Map<tbEmpleados>(item);
            var modelo = new tbEmpleados()
            {
                Empl_DNI = item.Empl_DNI,
                Empl_PNombre = item.Empl_PNombre,
                Empl_SNombre = item.Empl_DNI,
                Empl_PApellido = item.Empl_PApellido,
                Empl_SApellido = item.Empl_SApellido,
                Empl_Sexo = item.Empl_Sexo,
                EstD_Id = item.EstD_Id,
                Depa_Codigo = item.Depa_Codigo,
                Muni_Codigo = item.Muni_Codigo,
                Empl_DireccionE = item.Empl_DireccionE,
                Empl_UsuarioCreacion = 1,
                Empl_FechaCreacion = DateTime.Now

            };
            var list = _generalServices.InsertarEmpleado(modelo);
            return Ok(list);
        }


    }
}