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

        [HttpGet("ddlDeparatmentos")]
        public IActionResult ListarDeptos()
        {
            var result =  _generalServices.ddlDeptos();

            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return StatusCode(500, new { message = result.Message });
            }
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
            if (list.Success)
            {
                return Ok(list);
            }
            else
            {
                return Problem(list.Message);
            }
        }

        [HttpGet("LlenarMunicipios/{Muni_Codigo}")]
        public IActionResult LlenarDeptos(string Muni_Codigo)
        {
            string error;
            var llenar = _generalServices.BuscarMunicipio(Muni_Codigo).ToList();
            //HttpContext.Session.SetString("Depa_id", Depa_Codigo);
            var id = llenar.FirstOrDefault()?.Muni_Codigo;
            var idde = llenar.FirstOrDefault()?.Depa_Codigo;
            var descripcion = llenar.FirstOrDefault()?.Muni_Descripcion;
            return Json(new { success = true, id, idde, descripcion });
        }

        [HttpPut("Actualizar")]
        public IActionResult Update(MunicipiosViewModel item)
        {

            var model = _mapper.Map<tbMunicipios>(item);
            var modelo = new tbMunicipios()
            {
                Muni_Codigo = item.Muni_Codigo,
                Depa_Codigo = item.Depa_Codigo,
                Muni_Descripcion = item.Muni_Descripcion,
                Muni_UsuarioModificacion = 1,
                Muni_FechaModificacion = DateTime.Now

            };
            var list = _generalServices.ActualizarMuni(modelo);
            if (list.Success)
            {
                return Ok(list);
            }
            else
            {
                return Problem(list.Message);
            }
        }

        [HttpDelete("Eliminar/{Muni_Codigo}")]
        public IActionResult Delete(string Muni_Codigo)
        { 
            var list = _generalServices.EliminarMunicipio(Muni_Codigo);
            if (list.Success)
            {
                return Ok(list);
            }
            else
            {
                return Problem(list.Message);
            }
        }

        [HttpGet("Detalles")]
        public IActionResult Details(string Muni_codigo)
        {
            var list = _generalServices.DetalleMunicipio(Muni_codigo);

            if (list.Success)
            {
                return Ok(list);
            }
            else
            {
                return Problem(list.Message);
            }
        }
    }
}
