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
    public class EstadosCivilesController : Controller
    {
        private readonly GeneralServices _generalServices;
        private readonly IMapper _mapper;

        public EstadosCivilesController(GeneralServices generalService, IMapper mapper)
        {
            _generalServices = generalService;
            _mapper = mapper;
        }

        [HttpGet("Listado")]
        public IActionResult Index()
        {
            var listado = _generalServices.ListadoEstadosCiviles();
            return Ok(listado);
        }


        [HttpPost("Create")]
        public IActionResult Create(EstadosCivilesViewModel item)
        {
            var model = _mapper.Map<tbEstadosCiviles>(item);
            var modelo = new tbEstadosCiviles()
            {
                EstD_Descripcion = item.EstD_Descripcion,
                EstD_UsuarioCreacion = 1,
                EstD_FechaCracion = DateTime.Now

            };
            var list = _generalServices.InsertarEstadoCivil(modelo);
            return Ok(list);
        }
    }
}
