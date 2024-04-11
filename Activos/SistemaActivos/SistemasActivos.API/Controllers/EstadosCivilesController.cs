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
            if (list.Success)
            {
                return Ok(list);
            }
            else
            {
                return Problem(list.Message);
            }
        }

        [HttpGet("LlenarEstadosCiviles/{EstD_Id}")]
        public IActionResult LlenarDeptos(int EstD_Id)
        {
            string error;
            var llenar = _generalServices.BuscarEstadoCivil(EstD_Id).ToList();
            //HttpContext.Session.SetString("Depa_id", Depa_Codigo);
            var id = llenar.FirstOrDefault()?.EstD_Id;
            var descripcion = llenar.FirstOrDefault()?.EstD_Descripcion;
            return Json(new { success = true, id, descripcion });
        }

        [HttpPut("Actualizar")]
        public IActionResult Update(EstadosCivilesViewModel item)
        {

            var model = _mapper.Map<tbEstadosCiviles>(item);
            var modelo = new tbEstadosCiviles()
            {
                EstD_Id = item.EstD_Id,
                EstD_Descripcion = item.EstD_Descripcion,
                EstD_UsuarioModificacion = 1,
                EstD_FechaModificacion = DateTime.Now

            };
            var list = _generalServices.ActualizarEstado(modelo);
            if (list.Success)
            {
                return Ok(list);
            }
            else
            {
                return Problem(list.Message);
            }
        }

        [HttpDelete("Eliminar/{EstD_Id}")]
        public IActionResult Delete(int EstD_Id)
        {
            var list = _generalServices.EliminarEstado(EstD_Id);
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
        public IActionResult Details(int EstD_Id)
        {
            var list = _generalServices.BuscarEstadosDetalle(EstD_Id);

            return Ok(list);
        }
    }
}
