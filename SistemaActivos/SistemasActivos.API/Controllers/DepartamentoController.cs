using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaActivos.DataAccess;
using SistemaDeActivos.BusinessLogic;
using AutoMapper;
using SistemaActivos.Entities.Entities;

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

        [HttpPost("Insertar")]
        public IActionResult InsertarDepartamento(tbDepartamentos departamentoDto)
        {
            try
            {
                var departamento = _mapper.Map<tbDepartamentos>(departamentoDto);
                string mensaje = _generalServices.InsertarDepto(departamento);
                return Ok(mensaje);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error del servidorr" + ex.Message);
            }
        }


    }
}
