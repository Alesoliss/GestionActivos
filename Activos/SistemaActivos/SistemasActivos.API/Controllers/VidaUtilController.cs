using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaActivos.DataAccess;
using SistemaDeActivos.BusinessLogic;
using AutoMapper;
using SistemaActivos.Entities.Entities;
using SistemaActivos.Common.Model;
using Microsoft.AspNetCore.Http;

namespace SistemasActivos.API.Controllers
{
    [ApiController]
    [Route("/API/[controller]")]
    public class VidaUtilController : Controller
    {
        private readonly ActiveService _activeService;
        private readonly IMapper _mapper;

        public VidaUtilController(ActiveService activeService, IMapper mapper)
        {
            _activeService = activeService;
            _mapper = mapper;
        }
        [HttpGet("Listado")]
        public IActionResult Index()
        {
            var listado = _activeService.ListadoVida();

            return Ok(listado);
        }


        [HttpPost("Create")]
        public IActionResult Insert(VidaUtilViewmodel item)
        {
            var model = _mapper.Map<tbVidaUtil>(item);
            var modelo = new tbVidaUtil()
            {
                VidU_Descripcion = item.VidU_Descripcion,
                VidU_VidaEstimada = item.VidU_VidaEstimada,

                VidU_UsuarioCreacion = 1,
                VidU_FechaCreacion = DateTime.Now

            };
            var list = _activeService.InsertarVida(modelo);
            if (list.Success)
            {
                return Ok(list);
            }
            else
            {
                return Problem(list.Message);
            }
        }




        [HttpPut("Actualizar")]
        public IActionResult Update(VidaUtilViewmodel item)
        {

            var model = _mapper.Map<tbVidaUtil>(item);
            var modelo = new tbVidaUtil()
            {
                VidU_Id = item.VidU_Id,

                VidU_Descripcion = item.VidU_Descripcion,
                VidU_VidaEstimada = item.VidU_VidaEstimada,
                VidU_UsuarioModificacion = 1,
                VidU_FechaCreacion = DateTime.Now

            };
            var list = _activeService.ActualizarVida(modelo);
            if (list.Success)
            {
                return Ok(list);
            }
            else
            {
                return Problem(list.Message);
            }
        }




        [HttpGet("LlenarVidaUtil/{VidU_Id}")]
        public IActionResult LlenarDeptos(int VidU_Id)
        {
            string error;
            var llenar = _activeService.BuscarVida(VidU_Id).ToList();
            var descripcion = llenar.FirstOrDefault()?.VidU_Descripcion;
            var cate = llenar.FirstOrDefault()?.Cate_Id;
            var estimado = llenar.FirstOrDefault()?.VidU_VidaEstimada;

            return Json(new { success = true, descripcion, cate, estimado });
        }



        [HttpDelete("Eliminar/{VidU_Id}")]
        public IActionResult Delete(int VidU_Id)
        {

            var list = _activeService.EliminarVida(VidU_Id);

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
        public IActionResult Details(int VidU_Id)
        {
            var list = _activeService.BuscarDetalleVida(VidU_Id);

            return Ok(list);
        }

    }
}
