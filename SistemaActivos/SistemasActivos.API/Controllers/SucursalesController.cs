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
    public class SucursalesController : Controller
    {
        private readonly GeneralServices _generalServices;
        private readonly IMapper _mapper;

        public SucursalesController(GeneralServices generalService, IMapper mapper)
        {
            _generalServices = generalService;
            _mapper = mapper;
        }

        [HttpGet("Listado")]
        public IActionResult Index()
        {
            var listado = _generalServices.ListadoSucursales();
            return Ok(listado);
        }

        [HttpPost("Create")]
        public IActionResult Create(SucursalesViewModel item)
        {
            var model = _mapper.Map<tbSucursales>(item);
            var modelo = new tbSucursales()
            {
                Sucu_Descripcion = item.Sucu_Descripcion,
                Depa_Codigo = item.Depa_Codigo,
                Muni_Codigo = item.Muni_Codigo,
                Sucu_DireccionExacta = item.Sucu_DireccionExacta,
                Sucu_UsuarioCreacion = 1,
                Sucu_FechaCreacion = DateTime.Now

            };
            var list = _generalServices.InsertarSucursales(modelo);
            return Ok(list);
        }
    }
}
