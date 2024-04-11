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
    public class ActivoController : Controller
    {
        private readonly ActiveService _activeService;
        private readonly IMapper _mapper;

        public ActivoController(ActiveService activeService, IMapper mapper)
        {
            _activeService = activeService;
            _mapper = mapper;
        }


        [HttpGet("ListadoActivo")]
        public IActionResult Index()
        {
            var listado = _activeService.ListadoActivoo();

            return Ok(listado);
        }


        [HttpGet("ListadoDashboard")]
        public IActionResult IndexDash()
        {
            var listado = _activeService.ListadoDash();

            return Ok(listado);
        }


        [HttpGet("ListadoPrecio")]
        public IActionResult IndexPrecio()
        {
            var listado = _activeService.ListadoPrecio();

            return Ok(listado);
        }

        [HttpGet("ListadoPFecha")]
        public IActionResult IndexFecha()
        {
            var listado = _activeService.ListadoFecha();

            return Ok(listado);
        }

        [HttpPost("CreateActivo")]
        public IActionResult Insert(ActivosViewmodel item)
        {
            var model = _mapper.Map<tbActivos>(item);
            var modelo = new tbActivos()
            {
                Acti_Url = item.Acti_Url,
                Acti_Descripcion = item.Acti_Descripcion,
                Acti_Precio = item.Acti_Precio,
                Acti_Marca = item.Acti_Marca,
                Acti_Modelo = item.Acti_Modelo,
                Acti_NoSerio = item.Acti_NoSerio,
                Empl_Id = item.Empl_Id,
                VidU_Id = item.VidU_Id,
                Cate_Id = item.Cate_Id,

                Acti_FechaAdquisicion = item.Acti_FechaAdquisicion,
                Acti_UsuarioCreacion = 1,
                Acti_FechaCreacion = DateTime.Now

            };
            var list = _activeService.InsertarActivo(modelo);
            return Ok(list);
        }







        [HttpPut("ActualizarActivo")]
        public IActionResult Update(ActivosViewmodel item)
        {

            var model = _mapper.Map<tbActivos>(item);
            var modelo = new tbActivos()
            {
                Acti_Id = item.Acti_Id,
                Acti_Url = item.Acti_Url,
                Acti_Descripcion = item.Acti_Descripcion,
                Acti_Precio = item.Acti_Precio,
                Acti_Marca = item.Acti_Marca,
                Acti_Modelo = item.Acti_Modelo,
                Acti_NoSerio = item.Acti_NoSerio,
                Empl_Id = item.Empl_Id,
                VidU_Id = item.VidU_Id,
                Acti_FechaAdquisicion = item.Acti_FechaAdquisicion,
                Acti_UsuarioModificacion = 1,
                Acti_FechaModificacion = DateTime.Now

            };
            var list = _activeService.ActualizarActivo(modelo);
            return Ok(list);
        }

        [HttpGet("LlenarActivo/{Acti_Id}")]
        public IActionResult LLenarActivos(int Acti_Id)
        {
            var llenar = _activeService.BuscarActivo(Acti_Id).ToList();
            var id = llenar.FirstOrDefault()?.Acti_Id;
            var url = llenar.FirstOrDefault()?.Acti_Url;
            var descripcion = llenar.FirstOrDefault()?.Acti_Descripcion;
            var precio = llenar.FirstOrDefault()?.Acti_Precio;
            var marca = llenar.FirstOrDefault()?.Acti_Marca;
            var modelo = llenar.FirstOrDefault()?.Acti_Modelo;
            var serie = llenar.FirstOrDefault()?.Acti_NoSerio;
            var empleado = llenar.FirstOrDefault()?.Encargado;
            var vida = llenar.FirstOrDefault()?.VidU_VidaEstimada;
            var adquicision = llenar.FirstOrDefault()?.Acti_FechaAdquisicion;

            return Json(new { success = true, id, url, descripcion, precio, marca, modelo, serie, empleado, vida, adquicision });
        }

        [HttpDelete("EliminarActivo/{Acti_Id}")]
        public IActionResult Delete(int Acti_Id)
        {

            var list = _activeService.EliminarActivo(Acti_Id);

            return Ok(list);

        }

        [HttpGet("DetallesActivo")]
        public IActionResult Details(int Acti_Id)
        {
            var list = _activeService.BuscarDetalle(Acti_Id);

            return Ok(list);
        }


        [HttpGet("listaVidaUtil")]
        public async Task<IActionResult> ListaVidaUtl()
        {
            var result = await _activeService.ObtenerVidaUtil();

            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return StatusCode(500, new { message = result.Message });
            }
        }


        [HttpGet("listaCategoria")]
        public async Task<IActionResult> ListaCategoria()
        {
            var result = await _activeService.ObtenerCategorias();

            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return StatusCode(500, new { message = result.Message });
            }
        }

    }
}
