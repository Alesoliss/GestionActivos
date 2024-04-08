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
    public class MunicipiosController : Controller
    {
        private readonly GeneralServices _generalServices;
        private readonly IMapper _mapper;

        public MunicipiosController(GeneralServices generalServices, IMapper mapper)
        {
            _generalServices = generalServices;
            _mapper = mapper;
        }

        [HttpGet("Listado")]
        public IActionResult Index()
        {
            var listado = _generalServices.ListadoMunicipios();
            return Ok(listado);
        }


        [HttpPost("Create")]
        public IActionResult Create(MunicipiosViewModel item)
        {
            var model = _mapper.Map<tbMunicipios>(item);
            var modelo = new tbMunicipios()
            {
                Muni_Codigo = item.Muni_Codigo,
                Depa_Codigo = item.Depa_Codigo,
                Muni_Descripcion = item.Muni_Descripcion,
                Muni_UsuarioCreacion = 1,
                Muni_FechaCreacion = DateTime.Now

            };
            var list = _generalServices.InsertarMunicipios(modelo);
            return Ok(list);
        }
    }
}
