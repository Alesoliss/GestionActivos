using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaActivos.DataAccess;
using SistemaDeActivos.BusinessLogic;
using AutoMapper;

namespace SistemasActivos.API.Controllers
{
    [ApiController]
    //[Route("/API/[controles]")]
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

        //[HttpGet("Listado")]
        //public IActionResult List()
        //{
        //    var listado = _generalServices.ListadoDepto1();
            
        //    return Ok(listado);
        //}

    }
}
