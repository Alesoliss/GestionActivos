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
    public class CategoriaController : Controller
    {
        private readonly ActiveService _activeService;
        private readonly IMapper _mapper;

        public CategoriaController(ActiveService activeService, IMapper mapper)
        {
            _activeService = activeService;
            _mapper = mapper;
        }
        [HttpGet("Listado")]

        public IActionResult Index()
        {
            var listado = _activeService.Listadocategoria();

            return Ok(listado);
        }


        [HttpPost("Create")]
        public IActionResult Insert(CategoriasViewmodel item)
        {
            var model = _mapper.Map<tbCategorias>(item);
            var modelo = new tbCategorias()
            {
                Cate_Descripcion = item.Cate_Descripcion,
                Cate_UsuarioCreacion = 1,
                Cate_FechaCreacion = DateTime.Now

            };
            var list = _activeService.Insertarcategoria(modelo);
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
        public IActionResult Update(CategoriasViewmodel item)
        {

            var model = _mapper.Map<tbCategorias>(item);
            var modelo = new tbCategorias()
            {
                Cate_Id = item.Cate_Id,

                Cate_Descripcion = item.Cate_Descripcion,
                Cate_UsuarioModificacion = 1,
                Cate_FechaModificacion = DateTime.Now

            };
            var list = _activeService.Actualizarcategoria(modelo);
            if (list.Success)
            {
                return Ok(list);
            }
            else
            {
                return Problem(list.Message);
            }
        }



        [HttpGet("LlenarCategoria/{Cate_Id}")]
        public IActionResult LlenarCategoria(int Cate_Id)
        {
            string error;
            var llenar = _activeService.Buscarcategoria(Cate_Id).ToList();
            var descripcion = llenar.FirstOrDefault()?.Cate_Descripcion;
            return Json(new { success = true, descripcion });
        }



        [HttpDelete("Eliminar/{Cate_Id}")]
        public IActionResult Delete(int Cate_Id)
        {

            var list = _activeService.Eliminarcategoria(Cate_Id);

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
        public IActionResult Details(int Cate_Id)
        {
            var list = _activeService.BuscarDetallecategoria(Cate_Id);

            return Ok(list);
        }

    }
}
