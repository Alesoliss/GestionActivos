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


        [HttpPost("Create")]
        public IActionResult Insert(DepartamentosViewmodel item)
        {
            var model = _mapper.Map<tbDepartamentos>(item);
            var modelo = new tbDepartamentos()
            {
                Depa_Codigo = item.Depa_Codigo,
                Depa_Descripcion = item.Depa_Descripcion,
                Depa_UsuarioCreacion = 1,
                Depa_FechaCreacion = DateTime.Now

            };
            var list = _generalServices.InsertarDepto(modelo);
            return Ok(list);
        }

        [HttpPut("Actualizar")]
        public IActionResult Update (DepartamentosViewmodel item)
        {
           
            var model = _mapper.Map<tbDepartamentos>(item);
            var modelo = new tbDepartamentos()
            {
                Depa_Codigo = item.Depa_Codigo,
                Depa_Descripcion = item.Depa_Descripcion,
                Depa_UsuarioModificacion = 1,
                Depa_FechaModificacion = DateTime.Now

            };
            var list = _generalServices.ActualizarDepto(modelo);
            return Ok(list);
        }

        [HttpGet("LlenarDepartamentos/{Depa_Codigo}")]
        public IActionResult LlenarDeptos(string Depa_Codigo)
        {
            string error;
            var llenar = _generalServices.BuscarDepto(Depa_Codigo).ToList();
            //HttpContext.Session.SetString("Depa_id", Depa_Codigo);
            var descripcion = llenar.FirstOrDefault()?.Depa_Descripcion;
            return Json(new { success = true, descripcion });
        }

        [HttpDelete("Eliminar")]
        public IActionResult Delete (DepartamentosViewmodel item)
        {
            var modelo = item.Depa_Codigo;

            var depa_codigo = modelo.ToString();
            var list = _generalServices.EliminarDepartamento(depa_codigo);

            return Ok(list);

        }
    }
}
