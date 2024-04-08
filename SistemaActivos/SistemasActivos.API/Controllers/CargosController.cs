using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SistemaActivos.Common.Model;
using SistemaActivos.Entities.Entities;
using SistemaDeActivos.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemasActivos.API.Controllers
{
    [ApiController]
    [Route("/API/[controller]")]
    public class CargosController : Controller
    {
        private readonly GeneralServices _generalServices;
        private readonly IMapper _mapper;

        public CargosController(GeneralServices generalServices, IMapper mapper)
        {
            _generalServices = generalServices;
            _mapper = mapper;
        }

        [HttpGet("Listado")]
        public IActionResult Index()
        {
            var listado = _generalServices.ListadoCargo();
            return Ok(listado);
        }

        [HttpPost("Create")]
        public IActionResult Create(CargosViewModel item)
        {
            var model = _mapper.Map<tbCargos>(item);
            var modelo = new tbCargos()
            {
                Carg_Descripcion = item.Carg_Descripcion,
                Carg_UsuarioCreacion = 1,
                Carg_FechaCreacion = DateTime.Now

            };
            var list = _generalServices.InsertarCargo(modelo);
            return Ok(list);
        }

    }
}
