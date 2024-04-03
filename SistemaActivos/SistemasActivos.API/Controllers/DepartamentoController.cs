using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaActivos.DataAccess;
using SistemaDeActivos.BusinessLogic;
using AutoMapper;
using SistemaActivos.Entities.Entities;
using SistemasActivos.API.Model;

namespace SistemasActivos.API.Controllers
{
    [ApiController]
    public class DepartamentoController : Controller
    {
        private readonly GeneralServices _generalServices;
        private readonly IMapper _mapper;

        public DepartamentoController(GeneralServices generalService, IMapper mapper)
        {
            _generalServices = generalService;
            _mapper = mapper;
        }

        [HttpGet("Listado")]

        public IActionResult Index()
        {
            var listado = _generalServices.ListadoDepto1();

            return Ok(listado);
        }

        //[HttpPost("Insertar")]
        //public IActionResult InsertarDepartamento(tbDepartamentos departamentoDto)
        //{
        //    try
        //    {
        //        var departamento = _mapper.Map<tbDepartamentos>(departamentoDto);
        //        string mensaje = _generalServices.InsertarDepto(departamento);
        //        return Ok(mensaje);
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, "Error del servidorr" + ex.Message);
        //    }
        //}


        [HttpPost("Insert")]
        public IActionResult Insert(DepartamentosViewmodel item)
        {
            var model = _mapper.Map<tbDepartamentos>(item);
            var modelo = new tbDepartamentos()
            {
                Depa_Codigo = item.Depa_Codigo,
                Depa_Descripcion = item.Depa_Descripcion,
                Depa_UsuarioCreacion = item.Depa_UsuarioCreacion,
                Depa_FechaCreacion = item.Depa_FechaCreacion

            };
            var list = _generalServices.InsertarDepto(modelo);
            return Ok(list);
        }


    }
}
