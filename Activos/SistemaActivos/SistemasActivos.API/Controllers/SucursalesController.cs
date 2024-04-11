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
            if (list.Success)
            {
                return Ok(list);
            }
            else
            {
                return Problem(list.Message);
            }

        }

        [HttpGet("LlenarCategoria/{Sucu_Id}")]
        public IActionResult LlenarCategoria(int Sucu_Id)
        {
            string error;
            var llenar = _generalServices.BuscarSucursal(Sucu_Id).ToList();
            var id = llenar.FirstOrDefault()?.Sucu_Id;
            var descripcion = llenar.FirstOrDefault()?.Sucu_Descripcion;
            var direccion = llenar.FirstOrDefault()?.Sucu_DireccionExacta;
            var municipio = llenar.FirstOrDefault()?.Muni_Codigo;
            var departamento = llenar.FirstOrDefault()?.Depa_Codigo;

            return Json(new { success = true, id, descripcion, direccion, municipio, departamento });
        }

        [HttpPut("Actualizar")]
        public IActionResult Update(SucursalesViewModel item)
        {

            var model = _mapper.Map<tbSucursales>(item);
            var modelo = new tbSucursales()
            {
                Sucu_Id = item.Sucu_Id,
                Sucu_Descripcion = item.Sucu_Descripcion,
                Depa_Codigo = item.Depa_Codigo,
                Muni_Codigo = item.Muni_Codigo,
                Sucu_DireccionExacta = item.Sucu_DireccionExacta,
                Sucu_UsuarioModificacion = 1,
                Sucu_FechaModificacion = DateTime.Now

            };
            var list = _generalServices.ActualizarSucursal(modelo);
            if (list.Success)
            {
                return Ok(list);
            }
            else
            {
                return Problem(list.Message);
            }
        }
        [HttpDelete("Eliminar/{Sucu_Id}")]
        public IActionResult Delete(int Sucu_Id)
        {

            var list = _generalServices.EliminarSucursal(Sucu_Id);

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
