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
            if (list.Success)
            {
                return Ok(list);
            }
            else
            {
                return Problem(list.Message);
            }
        }

        [HttpGet("LlenarCargos/{Carg_Id}")]
        public IActionResult LlenarCargos(int Carg_Id)
        {
            var llenar = _generalServices.BuscarCargo(Carg_Id).ToList();
            var id = llenar.FirstOrDefault()?.Carg_Id;
            var descripcion = llenar.FirstOrDefault()?.Carg_Descripcion;
            return Json(new { success = true, id, descripcion });
        }

        [HttpPut("Actualizar")]
        public IActionResult Update(CargosViewModel item)
        {

            var model = _mapper.Map<tbCargos>(item);
            var modelo = new tbCargos()
            {
                Carg_Id = item.Carg_Id,
                Carg_Descripcion = item.Carg_Descripcion,
                Carg_UsuarioModificacion = 1,
                Carg_FechaModificacion = DateTime.Now

            };
            var list = _generalServices.ActualizarCargo(modelo);
            if (list.Success)
            {
                return Ok(list);
            }
            else
            {
                return Problem(list.Message);
            }
        }

        [HttpDelete("Eliminar/{Carg_Id}")]
        public IActionResult Delete(int Carg_Id)
        {
            var list = _generalServices.EliminarCargo(Carg_Id);
            return Ok(list);
        }

        [HttpGet("Detalles")]
        public IActionResult Details(int Carg_Id)
        {
            var list = _generalServices.DetalleCargo(Carg_Id);

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
